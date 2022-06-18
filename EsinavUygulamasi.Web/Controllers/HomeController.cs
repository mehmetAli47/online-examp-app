using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulaması.Models;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Controllers
{
    public class HomeController :Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IinstitutionService _institutionService;
        private readonly IExamService _examService;
        private readonly IQuestionService _questionService;
        private readonly ITestService _testService;
        public HomeController(ILogger<HomeController> logger , IinstitutionService institutionService,
            IExamService examService,IQuestionService questionService,ITestService testService) : base()
        {
            _logger = logger;
            _institutionService = institutionService;
            _examService = examService;
            _questionService = questionService;
            _testService= testService;
        }

        public IActionResult Index()
        {
            var institutionList = _institutionService.GetInstitutionListByFilter(null).ObjectList;
            return View(institutionList);
        }

        public IActionResult InstitutionExams(int id)
        {
            var examlist = _examService.GetExamListInstitutionByIdAsync(id).GetAwaiter().GetResult().ObjectList;
            return View(examlist);
        }

        public IActionResult Privacy()
        {
            var startTim = _testService.GetTestListByIdAsync(43).GetAwaiter().GetResult().ObjectList;
            ViewBag.Start=startTim.Select(a=>a.CreateTime).FirstOrDefault();
            return View();
        }
        public IActionResult ExamsQuestion(int id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
