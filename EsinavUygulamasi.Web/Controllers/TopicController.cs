using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EsinavUygulamasi.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicService _topicService;
        private readonly IQuestionService _questionService;

        public TopicController(ITopicService topicService,IQuestionService questionService)
        {
            _topicService = topicService;
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            var values = _topicService.GetTopicListByFilter(null).ObjectList;

            return View(values);
        }
        public IActionResult TopicQuestion(int id)
        {
            var topicName = _topicService.GetTopicListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            ViewBag.TopicName=topicName.Select(a=>a.Name).OfType<string>().First();
            var question = _questionService.GetQuestionListByTopicIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(question);
        }

    }
}
