using EsinavUygulamasi.Controllers;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace EsinavUygulamasi.Areas.Student.Controllers
{
    [Area("Student")]
    public class TestController : StudentBaseController
    {
        IQuestionService _questionService;
        ITestService _testService;
        IUserTestSerevice _userTestService;

        public TestController(IQuestionService questionService, ITestService testService,IUserTestSerevice userTestSerevice):base()
        {
            _questionService = questionService;
            _testService = testService;
            _userTestService = userTestSerevice;
        }

        public IActionResult Index(int id)
        {
            var testList = _testService.GetTestListByExamIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(testList);
        }
        public IActionResult TestContent(int Id)
        {
            var exam=_testService.GetTestListByIdAsync(Id).GetAwaiter().GetResult().ObjectList;
           var examId=exam.Select(a => a.ExamId).FirstOrDefault();
            ViewBag.ExamId = examId;
            ViewBag.TestId = Id;
            var questionList = _questionService.GetQuestionListByTestIdAsync(Id).GetAwaiter().GetResult().ObjectList;
            return View(questionList);
        }
      [HttpPost]
        public IActionResult TestContent([FromBody] EsinavUygulamasi.Models.Response.UserTestVM userTestVM)
        {
            var userId = JsonConvert.DeserializeObject<Models.UserVM>(HttpContext.Session.GetString("SessionUser"));
            var userTest = _userTestService.AddTestResult(userTestVM, userId.Id).GetAwaiter().GetResult();
            return Json(userTest);
        }
        public IActionResult TestResult(int Id)
        {
            var exam = _testService.GetTestListByIdAsync(Id).GetAwaiter().GetResult().ObjectList;
            var examId = exam.Select(a => a.ExamId).FirstOrDefault();
            ViewBag.ExamId = examId;
            var userId = JsonConvert.DeserializeObject<Models.UserVM>(HttpContext.Session.GetString("SessionUser"));
            var userTestAnswer = _userTestService.GetUserTestAnswerListById(userId.Id, Id).GetAwaiter().GetResult().ObjectList;
            return View(userTestAnswer);
        }
    }
}
