using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ExamController : AdminBaseController
    {
        IExamService _examService;
        IinstitutionService _institutionService;

        public ExamController(IExamService examService,IinstitutionService ınstitutionService):base()
        {
            _examService = examService;
            _institutionService = ınstitutionService;
        }

        public IActionResult Index()
        {
            var examList = _examService.GetExamsListByFilter(null).ObjectList;
            return View(examList);
        }
        public IActionResult AddExam()
        {
            var insList=_institutionService.GetInstitutionListByFilter(null).ObjectList;
            ViewBag.InsList = insList.Select(a => new SelectListItem()
            {
                Text = a.Name,
                Value = a.Id.ToString(),
            });
            return View(insList);
        }
        [HttpPost]
        public IActionResult AddExam(EsinavUygulamasi.Models.Response.ExamVM examVM)
        {
            var examList=_examService.AddExam(examVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Exam", new { area = "Admin" });
        }
        public IActionResult UpdateExam(int id)
        {
            var examValues = _examService.GetExamListByIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            ViewBag.InsList = _institutionService.GetInstitutionListByFilter(null).ObjectList.Select(a => new SelectListItem()
            {
                Text = a.Name,
                Value = a.Id.ToString(),
            });
            return View(examValues);
        }
        [HttpPost]
        public IActionResult UpdateExam(EsinavUygulamasi.Models.Response.ExamVM examVM)
        {
            var examList=_examService.UpdateExam(examVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Exam", new { area = "Admin" });
        }
        public IActionResult DeleteExam(int id)
        {
            var exam = _examService.GetExamListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            
            return View(exam);
        }
        [HttpPost]
        public IActionResult DeleteExam(EsinavUygulamasi.Models.Response.ExamVM examVM)
        {
            var exam=_examService.DeleteExam(examVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Exam", new { area = "Admin" });
        }
    }
}
