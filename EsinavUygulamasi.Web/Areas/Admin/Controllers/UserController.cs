
using EsinavUygulamasi.DAL;
using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class UserController : EsinavUygulamasi.Controllers.AdminBaseController
    {
        IUserService _userService;
        IRoleService _roleService;
        public UserController(IUserService userService,
            IRoleService roleService) : base()
        {
            _userService = userService;
            _roleService = roleService;
        }


        public IActionResult Index()
        {
            var userList = _userService.GetUserListByFilter(null).ObjectList;
            return View(userList);
        }
        public IActionResult UserUpdate(int id)
        {
            var userItem = _userService.GetUserListByIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            userItem.Role=_userService.GetRoleListByUserIdAsync(id).GetAwaiter().GetResult().ObjectList;
            ViewBag.RoleList = _roleService.GetRoleListByFilter(null).ObjectList.Select(a => new SelectListItem()
            {
                Text = a.Name,
                Value = a.Id.ToString()
            });
            return View(userItem);
        }

        [HttpPost]
        public IActionResult UserUpdate(EsinavUygulamasi.Models.UserVM user)
        {
            var userList = _userService.UpdateUserAsync(user).GetAwaiter().GetResult();

            return RedirectToAction("Index", "User", new { area = "Admin" });
        }
        public IActionResult UserDelete(int id)
        {
            var userList = _userService.GetUserListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(userList);
        }

        [HttpPost]
        public IActionResult UserDelete(UserVM user)
        {
            var userList = _userService.DeleteUserAsync(user).GetAwaiter().GetResult();

            return RedirectToAction("Index", "User", new { area = "Admin" });
        }
    }
}
