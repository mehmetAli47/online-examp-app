using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AnalysisController : AdminBaseController
    {
        IUserService userService;

        public AnalysisController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult UsersTestStat()
        {
            var statList = userService.GetUsersTestStatByFilter(null).ObjectList;
            return View(statList);
        }
    }
}
