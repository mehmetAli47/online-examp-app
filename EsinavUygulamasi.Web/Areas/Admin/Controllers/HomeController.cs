using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : AdminBaseController
    {
        IUserService userService;

        public HomeController(IUserService userService):base()
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var userList = userService.GetUserListByFilter(null).ObjectList;
            return View();
        }
       
    }
}
