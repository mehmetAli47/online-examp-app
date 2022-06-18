using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : StudentBaseController
    {
        IinstitutionService _institutionService;

        public HomeController(IinstitutionService institutionService):base()
        {
            _institutionService = institutionService;
        }

        public IActionResult Index()
        {
            var ins = _institutionService.GetInstitutionListByFilter(null).ObjectList;
            return View(ins);
        }
    }
}
