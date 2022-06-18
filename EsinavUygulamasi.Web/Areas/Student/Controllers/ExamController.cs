using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Areas.Student.Controllers
{
    [Area("Student")]
    public class ExamController : StudentBaseController
    {
        IExamService _examService;

        public ExamController(IExamService examService):base()
        {
            _examService = examService;
        }

        public IActionResult Index(int id)
        {
            var examList = _examService.GetExamListInstitutionByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(examList);
        }
    }
}
