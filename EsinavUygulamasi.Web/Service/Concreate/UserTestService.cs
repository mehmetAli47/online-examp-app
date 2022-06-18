using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Concreate
{
    public class UserTestService : IUserTestSerevice
    {
        IGenericRepository<Test> _testRepository;
        IGenericRepository<Question> _questionRepository;
        IGenericRepository<UserTest> _userTestRepository;
        IGenericRepository<UserTestInformationView> _userTestInfoRepository;
        

        public UserTestService(IGenericRepository<UserTest> usertestRepository, IGenericRepository<Test> testRepository,
            IGenericRepository<Question> questionRepository, IGenericRepository<UserTestInformationView> userTestInfoRepository
            )
        {
            _userTestRepository = usertestRepository;
            _testRepository = testRepository;
            _questionRepository = questionRepository;
            _userTestInfoRepository = userTestInfoRepository;
           

        }

        public async Task<ResponseVM> AddTestResult(UserTestVM userTestVM, int id)
        {
            ResponseVM responseVM = new ResponseVM();
            var oldQuestionAnswers = _userTestRepository.GetAll().Where(a => a.UserId == id && a.TestId == userTestVM.TestId).ToList();//bu kullanıcı bu teste daha önceden vermiş olduğu cevapları getir
            oldQuestionAnswers.ForEach(a => _userTestRepository.Delete(a));                                                          // bu kullanıcının önceki cevaplarını sil-ForEach: Her bir öğe üzerinde belirtilen işlemi uygular
            var answeredQuestionIdlist = userTestVM.QuestionAnswerList.Select(b => b.QuestionId).ToList();
            var questions = _questionRepository.GetAll().Where(a => answeredQuestionIdlist.Contains(a.Id)).ToList();                 // Contains:Koleksiyon içindeki verileri control eder aranan değer var ise true yoksaise yanlış değerini döndürür
            foreach (var item in userTestVM.QuestionAnswerList)
            {
                var userTest = new UserTest()
                {
                    TestId = userTestVM.TestId,
                    UserId = id,
                    QuestionAnswer = item.QuestionAnswer,
                    QuestionId = item.QuestionId,
                    Status = questions.Where(a => a.Id == item.QuestionId).FirstOrDefault()?.CorrectAnswer == item.QuestionAnswer
                };
                await _userTestRepository.CreateAsync(userTest);
            }
            await _userTestRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }

        public async Task<ResponseVM> DeleteUserTest(int testid)
        {
            ResponseVM responseVM = new ResponseVM();

            var deletedValue = await (from ut in _userTestRepository.GetAll()
                                      where ut.TestId == testid
                                      select ut
                              ).ToListAsync();

            deletedValue.ForEach(a => _userTestRepository.Delete(a));
            await _userTestRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }

       

        public async Task<GetListResponseVM<UserTest>> GetUserTestAnswerListById(int userId, int testId)
        {
            var userTestAnswer = await (from ut in _userTestRepository.GetAll()
                                        join q in _questionRepository.GetAll() on ut.QuestionId equals q.Id
                                        where ut.UserId == userId && ut.TestId == testId
                                        select new UserTest()
                                        {
                                            Id = ut.Id,
                                            TestId = ut.TestId,
                                            UserId = ut.UserId,
                                            QuestionAnswer = ut.QuestionAnswer,
                                            QuestionId = ut.QuestionId,
                                            Question = ut.Question,
                                            Status = ut.Status,
                                        }
                                        ).ToListAsync();
            return new GetListResponseVM<UserTest>()
            {
                IsSuccess = true,
                ObjectList = userTestAnswer,
            };
        }

        public async Task<GetListResponseVM<UserTestInformationView>> GetUserTestInformationList(int testId)
        {
            var info = await (from ut in _userTestInfoRepository.GetAll()
                              where ut.TestId == testId
                              select new UserTestInformationView()
                              {
                                  Id = ut.Id,
                                  TestId= ut.TestId,
                                  Name = ut.Name,
                                  QuestionAnswer = ut.QuestionAnswer,
                                  QuestionName = ut.QuestionName,
                                  TestName = ut.TestName,
                                  Status=ut.Status,
                              }
                            ).ToListAsync();

            return new GetListResponseVM<UserTestInformationView>()
            {
                IsSuccess = true,
                ObjectList = info,
            };
        }
    }
}
