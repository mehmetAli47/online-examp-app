using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class InstitutionController : EsinavUygulamasi.Controllers.AdminBaseController
    {
        IinstitutionService _institutionService;

        public InstitutionController(IinstitutionService institutionService) :base()
        {
            _institutionService = institutionService;
        }

        public IActionResult Index()
        {
            var insList = _institutionService.GetInstitutionListByFilter(null).ObjectList;
            return View(insList);
        }

        public IActionResult InstitutionAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InstitutionAdd(EsinavUygulamasi.Models.Response.InstitutionVM ınstitutionVM)
        {
            var ınsSaveResult = _institutionService.AddInstitutionAsync(ınstitutionVM).GetAwaiter().GetResult();

            return RedirectToAction("Index", "Institution", new { area = "Admin" });
        }
        public IActionResult UpdateInstitution(int id)
        {
            var institutionList = _institutionService.GetInstitutionListByIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();

            return View(institutionList);
        }
        [HttpPost]
        public IActionResult UpdateInstitution(EsinavUygulamasi.Models.Response.InstitutionVM ınstitutionVM)
        {
            var insList = _institutionService.UpdateInstitution(ınstitutionVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Institution", new { area = "Admin" });
        }

        public IActionResult DeleteInstitution(int id)
        {
            var insList = _institutionService.GetInstitutionListByIdAsync(id).GetAwaiter().GetResult().ObjectList;

            return View(insList);
        }
        [HttpPost]
        public IActionResult DeleteInstitution(EsinavUygulamasi.Models.Response.InstitutionVM ınstitutionVM)
        {
            var instList = _institutionService.DeleteInstitution(ınstitutionVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Institution", new { area = "Admin" });
        }
    }
}
