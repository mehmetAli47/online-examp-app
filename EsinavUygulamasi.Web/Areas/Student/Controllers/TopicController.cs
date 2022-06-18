using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Areas.Student.Controllers
{
    [Area("Student")]
    public class TopicController : StudentBaseController
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
    }
}
