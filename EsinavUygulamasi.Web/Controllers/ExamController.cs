using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Controllers
{
    public class ExamController : Controller
    {
        readonly IExamService _examService;
        public ExamController(IExamService examService) 
        {
            _examService = examService;
        }
        // GET: ExamController
        public ActionResult Index()
        {
            var examsList = _examService.GetExamsListByFilter(null).ObjectList;
            return View(examsList);
        }

        
       
    }
}
