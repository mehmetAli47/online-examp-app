using EsinavUygulamasi.DAL;
using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EsinavUygulamasi.Controllers
{
    public class UserController :Controller
    {
        readonly IUserService _userService;
        public UserController(IUserService userService ) 
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var userList = _userService.GetUserListByFilter(null).ObjectList;
            return View(userList);
            
        }
        public IActionResult UserAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult UserAdd(EsinavUygulamasi.Models.UserVM userVm)
        {
            var userSaveResult=_userService.AddUserAsync(userVm).GetAwaiter().GetResult();
            if (userSaveResult.IsSuccess)
            {
                ViewBag.User = userVm.Name + userVm.SurName;
               
            }
            else
            {
                ViewBag.Error = userSaveResult?.Error?.Error;
            }
            return RedirectToAction("Index","Home");
        }
    }
}
