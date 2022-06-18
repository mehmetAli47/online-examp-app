using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Concreate
{
    public class TestService : ITestService
    {
        IGenericRepository<Test> _testRepository;
        IGenericRepository<TestQuestion> _testQuestionRepository;
        IGenericRepository<Question> _questionRepository;
        IUserTestSerevice _userTestSerevice;
        IGenericRepository<UserInTheTest> _userInTheTestRepository;
        IGenericRepository<User> _userRepository;
        IGenericRepository<UserTest> _userTestRepository;
        public TestService(IGenericRepository<Test> genericRepository, IGenericRepository<Question> questionGenericRepository, 
            IGenericRepository<TestQuestion> testQuestionRepository,IUserTestSerevice userTestSerevice,
            IGenericRepository<UserInTheTest> userInTheTestRepository,IUserService userService,
            IGenericRepository<UserTest> userTestRepository,IGenericRepository<User> userRepository)
        {
            _testRepository = genericRepository;
            _testQuestionRepository = testQuestionRepository;
            _questionRepository = questionGenericRepository;
            _userTestSerevice = userTestSerevice;
            _userInTheTestRepository= userInTheTestRepository;
           _userRepository = userRepository;
            _userTestRepository = userTestRepository;
        }

        public async Task<ResponseVM> AddTestAsync(TestVM testVM)
        {
            ResponseVM responseVM = new ResponseVM();
            if (testVM == null || string.IsNullOrEmpty(testVM.Name))
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "Lüfen zorunlu alanları doldurunuz"
                };
            }
            var testDb = new Test()
            {
                Name = testVM.Name,
                StartTime = testVM.StartTime,
                CreateTime = DateTime.Now,
                NumberOfQuestion = testVM.NumberOfQuestion,
                LastUpdateTime = DateTime.Now,
            };
            await _testRepository.CreateAsync(testDb);
            await _testRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }
        public async Task<ResponseVM> DeleteTestAsync(TestVM testVM)
        {
            var testDb = _testRepository.GetAll().Where(a => a.Id == testVM.Id).FirstOrDefault();
           var userTestDb=_userTestSerevice.DeleteUserTest(testVM.Id).GetAwaiter().GetResult();
            ResponseVM responseVM = new ResponseVM();
            if (testDb == null || string.IsNullOrEmpty(testVM.Name))
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "Test bilgisi bulunamadı"
                };
            }
            _testRepository.Delete(testDb);
            await _testRepository.SaveChangesAsync();
            return responseVM;
        }

        public GetListResponseVM<Test> GetTestListByFilter(Expression<Func<Test, bool>> predicate)
        {
            var test = _testRepository.GetAll();
            if (predicate != null)
                test = test.Where(predicate);
            var testList = test.ToList();
            return new GetListResponseVM<Test>()
            {
                IsSuccess = true,
                ObjectList = testList
            };
        }

        public async Task<GetListResponseVM<TestVM>> GetTestListByExamIdAsync(int id)
        {
            var testList = await (from t in _testRepository.GetAll()
                                  where t.ExamId == id
                                  select new TestVM()
                                  {
                                      Id = t.Id,
                                      CreateTime = t.CreateTime,
                                      Name = t.Name,
                                      LastUpdateTime = t.LastUpdateTime,
                                      NumberOfQuestion = t.NumberOfQuestion,
                                      StartTime = t.StartTime,
                                      ExamId = t.ExamId,
                                  }).ToListAsync();
            return new GetListResponseVM<TestVM>()
            {
                IsSuccess = true,
                ObjectList = testList
            };
        }

        public async Task<ResponseVM> SaveTest(TestVM testVM)
        {
            ResponseVM responseVM = new ResponseVM();
            var testDb = new Test()
            {
                Name = testVM.Name,
                NumberOfQuestion = testVM.QuestionIdList.Count(),
                ExamId=testVM.ExamId,
                CreateTime = DateTime.Now,
                StartTime = testVM.StartTime
            };
            if (testVM.QuestionIdList != null)
            {
                testDb.TestQuestions = new List<TestQuestion>();
                foreach (var item in testVM.QuestionIdList)
                {
                    testDb.TestQuestions.Add(new TestQuestion()
                    {
                        QuestionId = item,
                    });
                }
            }
            await _testRepository.CreateAsync(testDb);
            await _testRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }
        public async Task<ResponseVM> UpdateTestAsync(TestVM testVM)
        {
            var testDb = _testRepository.GetAll().Where(a => a.Id == testVM.Id).FirstOrDefault();
            var testQuestionDb=_testQuestionRepository.GetAll().Where(a => a.TestId == testVM.Id).ToList();
            testQuestionDb.ForEach(a => _testQuestionRepository.Delete(a));
            testDb.TestQuestions.ForEach(a => _testQuestionRepository.Delete(a));
            ResponseVM responseVM = new ResponseVM();
            if (testDb == null || string.IsNullOrEmpty(testVM.Name))
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "Zorunlu alanları doldurunuz"
                };
            }
            testDb.Name = testVM.Name;
            testDb.StartTime = testVM.StartTime;
            testDb.NumberOfQuestion = testVM.NumberOfQuestion;
            testDb.LastUpdateTime = testVM.LastUpdateTime;

            if (testVM.QuestionIdList != null)
            {
                testDb.TestQuestions = new List<TestQuestion>();
                foreach (var question in testVM.QuestionIdList)
                {
                    testDb.TestQuestions.Add(new TestQuestion()
                    {
                        QuestionId = question
                    });
                }
            }


            _testRepository.Update(testVM.Id, testDb);
            await _testRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }

        public async Task<GetListResponseVM<TestVM>> GetTestListByIdAsync(int id)
        {
            var testList = await (from t in _testRepository.GetAll()
                                 where t.Id == id
                                 select new TestVM()
                                 {
                                     Id = t.Id,
                                     CreateTime = t.CreateTime,
                                     Name = t.Name,
                                     LastUpdateTime = t.LastUpdateTime,
                                     NumberOfQuestion = t.NumberOfQuestion,
                                     StartTime = t.StartTime,
                                     ExamId = t.ExamId,
                                 }).ToListAsync();
            return new GetListResponseVM<TestVM>()
            {
                IsSuccess = true,
                ObjectList = testList
            };
        }

        public GetListResponseVM<UserInTheTest> GetUserInTheTest(Expression<Func<UserInTheTest, bool>> predicate)
        {
            var userInTheTest = _userInTheTestRepository.GetAll();
            if(predicate!=null)
                userInTheTest=userInTheTest.Where(predicate);
            var userInTheTestList = userInTheTest.ToList();
            return new GetListResponseVM<UserInTheTest>()
            {
                IsSuccess = true,
                ObjectList = userInTheTestList
            };
        }

        /// <summary>
        /// Teste giren öğrenci bilgisi (Denenmedi)
        /// </summary>
        /// <param name="testVM"></param>
        /// <returns></returns>
        public async Task<GetListResponseVM<User>> GetUserInTheTestByTestIdAsync(TestVM testVM)
        {
            var userList = await (from u in _userRepository.GetAll()
                            join ut in _userTestRepository.GetAll() 
                            on u.Id equals ut.UserId
                            where ut.TestId == testVM.Id
                            select u
                          ).ToListAsync();
            return new GetListResponseVM<User>()
            {
                IsSuccess = true,
                ObjectList = userList,
            };
        }
    }

}
