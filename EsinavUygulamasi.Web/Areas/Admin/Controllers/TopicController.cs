using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class TopicController : EsinavUygulamasi.Controllers.AdminBaseController
    {
        ITopicService _topicService;

        public TopicController(ITopicService topicService):base()
        {
            _topicService = topicService;
        }

        public IActionResult Index()
        {
            var topicList = _topicService.GetTopicListByFilter(null).ObjectList;
            return View(topicList);
        }
        public IActionResult AddTopic()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTopic( EsinavUygulamasi.Models.Response.TopicVM topicVM)
        {
            var topic=_topicService.AddTopicAsync(topicVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Topic", new { area = "Admin" });
        }
        public IActionResult UpdateTopic(int id)
        {
            var topic=_topicService.GetTopicListByIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            return View(topic);
        }
        [HttpPost]
        public IActionResult UpdateTopic(EsinavUygulamasi.Models.Response.TopicVM topicVM)
        {
            var topic=_topicService.UpdateTopic(topicVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Topic", new { area = "Admin" });
        }
        public IActionResult DeleteTopic(int id)
        {
            var topic = _topicService.GetTopicListByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(topic);
        }
        [HttpPost]
        public IActionResult DeleteTopic(EsinavUygulamasi.Models.Response.TopicVM topicVM)
        {
            var topic = _topicService.DeleteTopic(topicVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Topic", new { area = "Admin" });
        }
    }
}
