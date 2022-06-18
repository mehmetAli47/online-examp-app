using EsinavUygulamasi.DAL;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Models.Response;
using EsinavUygulamasi.Service.Abstract;
using EsinavUygulamasi.Service.Concreate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsinavUygulaması.Controllers
{
    public class LoginController : Controller
    {
        readonly IUserService _userServce;
        public LoginController(IUserService userService)
        {
            _userServce = userService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserVM user)
        {

            var userDb = _userServce.GetUserListByFilter(a => a.Username == user.UserName && a.Password == user.Password)?.ObjectList?.FirstOrDefault();

            if (userDb != null)
            {
                var userRole = _userServce.GetRoleListByUserIdAsync(userDb.Id).GetAwaiter().GetResult().ObjectList;

                var usersesion = new UserVM() { UserName = userDb.Username, Id = userDb.Id, Name = userDb.Name, SurName = userDb.Surname, Role = userRole };
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(usersesion));
                var role = userRole.Select(a => a.Name).FirstOrDefault();
               
                //return to admin mangement
                if (role == "Admin")
                {

                    return RedirectToAction("Index", "User", new { area = "Admin" });
                }

                else if (role == "öğrenci")
                {
                    return RedirectToAction("Index", "Home", new { area = "Student" });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.Error = "Kullanıcı Bulunamadı";
                return View(user);
            }

        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}

