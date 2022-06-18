using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using X.PagedList;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class QuestionController : EsinavUygulamasi.Controllers.AdminBaseController
    {
        IQuestionService _questionService;
        ITopicService _topicService;

        public QuestionController(IQuestionService questionService, ITopicService topicService) :base()
        {
            _questionService = questionService;
            _topicService = topicService;
        }
        public IActionResult Index(int id)
        {
            var questionList = _questionService.GetQuestionListByTopicIdAsync(id).GetAwaiter().GetResult().ObjectList;
            var topic = _topicService.GetTopicListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            ViewBag.TopicId = id;
            ViewBag.TopicName = topic.Select(a => a.Name).OfType<string>().First();
            return View(questionList);
        }
        public IActionResult AddQuestion(int id)
        {
            ViewBag.topicId = id;
            var topic = _topicService.GetTopicListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            ViewBag.topicName=topic.Select(a => a.Name).OfType<string>().First();
            return View();
        }
        [HttpPost]
        public IActionResult AddQuestion(EsinavUygulamasi.Models.Response.QuestionVM questionVM)
        {
            var question = _questionService.AddQuestionAsync(questionVM).GetAwaiter().GetResult();

            //return RedirectToAction("Index", "Question", new { area = "Admin" });
            return RedirectToAction("Index","Question", new { id = questionVM.TopicId });
        }
        public IActionResult UpdateQuestion(int id)
        {
            var questin = _questionService.GetQuestionListByIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            ViewBag.QuestionTopicId = questin.TopicId;
            return View(questin);
        }
        [HttpPost]
        public IActionResult UpdateQuestion(EsinavUygulamasi.Models.Response.QuestionVM questionVM)
        {
            var question = _questionService.UpdateQuestion(questionVM).GetAwaiter().GetResult();

            return RedirectToAction("Index", new { id = questionVM.TopicId });
        }

        public IActionResult DeleteQuestion(int id)
        {
            ViewBag.TopicId=id;
            var question = _questionService.GetQuestionListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(question);
        }
        [HttpPost]
        public IActionResult DeleteQuestion(EsinavUygulamasi.Models.Response.QuestionVM questionVM)
        {
            var deleteQuestion = _questionService.GetQuestionListByIdAsync(questionVM.Id).GetAwaiter().GetResult();
            var question=_questionService.DeleteQuestion(questionVM).GetAwaiter().GetResult();
            return RedirectToAction("Index","Question", new { id = deleteQuestion.ObjectList.Select(a=>a.TopicId).FirstOrDefault() });
        }

        public IActionResult GetQuestion()
        {
            var question = _questionService.GetQuestionListByFilter(null).ObjectList;
            return View(question);
        }
    }
}
