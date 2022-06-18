using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Controllers
{
    public class QuestionController : Controller
    {
        readonly IQuestionService _questionService;

        public QuestionController (IQuestionService questionService) : base()
        {
            _questionService = questionService;
        }
        public IActionResult Index()
        {
            var questionList = _questionService.GetQuestionListByFilter(null).ObjectList;

            return View(questionList);
        }
    }
}
