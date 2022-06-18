using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Response;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EsinavUygulamasi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class TestController : AdminBaseController
    {
        ITestService _testService;
        IinstitutionService _institutionService;
        ITopicService _topicService;
        IQuestionService _questionService;
        ITestQuestionService _testquestionService;
        IExamService _examService;
        IUserTestSerevice _userTestService;
        public TestController(ITestService testService, IinstitutionService ıinstitutionService,
            IQuestionService questionService, ITopicService topicService, ITestQuestionService testQuestionService,IExamService examService,IUserTestSerevice userTestSerevice) 
        {
            _testService = testService;
            _institutionService = ıinstitutionService;
            _questionService = questionService;
            _topicService = topicService;
            _testquestionService = testQuestionService;
            _examService = examService;
            _userTestService = userTestSerevice;
        }

        public IActionResult Index(int Id)
        {
            ViewBag.ExamId=Id;
            var examName = _examService.GetExamListByIdAsync(Id).GetAwaiter().GetResult().ObjectList;
            ViewBag.ExamName=examName.Select(a=>a.Name).OfType<string>().First();
            var testList = _testService.GetTestListByExamIdAsync(Id).GetAwaiter().GetResult().ObjectList;
            return View(testList);
        }
        public IActionResult GetQuestion(int topicListTypeId)
        {
            var questionList = _questionService.GetQuestionListByFilter(a => a.TopicId == topicListTypeId).ObjectList;
            return Json(questionList);
        }
        public IActionResult SaveTest(int id)
        {
            var topicList = _topicService.GetTopicListByFilter(null).ObjectList;
            var questionList = _questionService.GetQuestionListByFilter(null).ObjectList;
            ViewBag.ExamId=id;
            ViewBag.Topic = topicList.Select(a => new SelectListItem()
            {
                Text = a.Name,
                Value = a.Id.ToString()
            });
            ViewBag.Question = questionList.Select(a => new SelectListItem()
            {
                Text = a.Name,
                Value = a.Id.ToString()
            });
            return View();
        }
        [HttpPost]
        public IActionResult SaveTest([FromBody] EsinavUygulamasi.Models.Response.TestVM testVM)
        {
            var test = _testService.SaveTest(testVM).GetAwaiter().GetResult();

            return RedirectToAction("Index", "Test", new { area = "Admin" });
        }
        public IActionResult GetQuestionListByTestId(int testListTypeId)
        {
            var testItem = _testService.GetTestListByIdAsync(testListTypeId).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            testItem.QuestionVM = _questionService.GetQuestionListByTestIdAsync(testListTypeId).GetAwaiter().GetResult().ObjectList;
            return Json(testItem);
        }
        public IActionResult UpdateTest(int id)
        {
            var testItem = _testService.GetTestListByIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            var topicList = _topicService.GetTopicListByFilter(null).ObjectList;
            var questionList = _questionService.GetQuestionListByFilter(null).ObjectList;
            ViewBag.Topic = topicList.Select(a => new SelectListItem()
            {
                Value = a.Id.ToString(),
                Text = a.Name
            });
            ViewBag.Question = questionList.Select(a => new SelectListItem()
            {
                Value = a.Id.ToString(),
                Text = a.Name
            });
            ViewBag.TestId =testItem.Id;

            return View(testItem);
        }
        [HttpPost]
        public IActionResult UpdateTest([FromBody] EsinavUygulamasi.Models.Response.TestVM testVM)
        {
            var test = _testService.UpdateTestAsync(testVM).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Test", new { area = "Admin" });
        }
        public IActionResult DeleteTest(int id)
        {
            var testItem = _testService.GetTestListByExamIdAsync(id).GetAwaiter().GetResult().ObjectList.FirstOrDefault();
            return View(testItem);
        }
        [HttpPost]
        public IActionResult DeleteTest(EsinavUygulamasi.Models.Response.TestVM test)
        {
            var testQuestion = _testquestionService.GetQuestionListTestById(test.Id).GetAwaiter().GetResult();
            var deleteTestItem = _testService.DeleteTestAsync(test).GetAwaiter().GetResult();
            return RedirectToAction("Index", "Test", new { area = "Admin" });
        }
        public IActionResult Test(int Id)
        {
            ViewBag.TestId = Id;
            var questionList = _questionService.GetQuestionListByTestIdAsync(Id).GetAwaiter().GetResult().ObjectList;
            return View(questionList);
        }
        [HttpPost]
        public IActionResult Test([FromBody] EsinavUygulamasi.Models.Response.TestVM testVM)
        {
            return RedirectToAction("Index", "Test", new { area = "Admin" });
        }
        /// <summary>
        ///Teste giren kullanıcıların test bilgileri
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult UserTestInformation(int id)
        {
            var info = _userTestService.GetUserTestInformationList(id).GetAwaiter().GetResult().ObjectList;
            return View(info);
        }

        public IActionResult UserInTheTest()
        {
            var userInTheTest = _testService.GetUserInTheTest(null).ObjectList;
            return View(userInTheTest);
        }

    }
}
