using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EsinavUygulamasi.Areas.Student.Controllers
{
    [Area("Student")]
    public class QuestionController : StudentBaseController
    {
        IQuestionService _questionService;
        ITopicService _topicService;

        public QuestionController(IQuestionService questionService,ITopicService topicService):base()
        {
            _questionService = questionService;
            _topicService = topicService;
        }

        public IActionResult Index(int id)
        {
            var topicName=_topicService.GetTopicListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            ViewBag.TopicName = topicName.Select(a => a.Name).OfType<string>().First();
            var questionList = _questionService.GetQuestionListByTopicIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(questionList);
        }
    }
}
