using EsinavUygulamasi.DAL.Models.Database;
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
    public class QuestionService:IQuestionService
    {
        IGenericRepository<Question> _questionRepository;
        IGenericRepository<TestQuestion> _testQuestionRepository;

        public  QuestionService(IGenericRepository<Question> questionRepository,IGenericRepository<TestQuestion> testQuestionRepository)
        {
            _questionRepository = questionRepository;
            _testQuestionRepository = testQuestionRepository;
        }

        public async Task<ResponseVM> AddQuestionAsync(QuestionVM questionVM)
        {
            ResponseVM responseVM = new ResponseVM();
            if(questionVM != null)
            {
                responseVM.Error=new ErrorResponseVM()
                {
                    Error="Lütfen zorunlu alanları doldurunuz"
                };
            }
            var questionList = new Question()
            {
                Answer1 =questionVM.Answer1,
                Answer2=questionVM.Answer2,
                Answer3 =questionVM.Answer3,
                Answer4 =questionVM.Answer4,
                CorrectAnswer=questionVM.CorrectAnswer,
                CreateTime=DateTime.Now,
                LastUpdateTime=DateTime.Now,
                Name=questionVM.Name,
                TopicId=questionVM.TopicId,
            };
            await _questionRepository.CreateAsync(questionList);
            await _questionRepository.SaveChangesAsync();
            responseVM.IsSuccess=true;
            return responseVM;
        }

        public async Task<ResponseVM> DeleteQuestion(QuestionVM questionVM)
        {
            var question = _questionRepository.GetAll().Where(a => a.Id == questionVM.Id).FirstOrDefault();
            ResponseVM responseVM = new ResponseVM();
            if (questionVM == null || string.IsNullOrEmpty(questionVM.Name))
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "Konu bilgisi Bulunamadı"
                };
            }
            _questionRepository.Delete(question);
            await _questionRepository.SaveChangesAsync();
            return responseVM;
        }

        public GetListResponseVM<Question> GetQuestionListByFilter(Expression<Func<Question, bool>> predicate)
        {
            var question = _questionRepository.GetAll();
            if (predicate != null)
                question = question.Where(predicate);
            var questionList=question.ToList();
            return new GetListResponseVM<Question>()
            {
                IsSuccess = true,
                ObjectList = questionList
            };
        }

        public async Task<GetListResponseVM<QuestionVM>> GetQuestionListByTopicIdAsync(int id)
        {
            var questionList = await (from q in _questionRepository.GetAll()
                                  where q.TopicId == id
                                  select new QuestionVM()
                                  {
                                    Answer1 = q.Answer1,
                                    Answer2 = q.Answer2,
                                    Answer3 = q.Answer3,
                                    Answer4 = q.Answer4,
                                    CorrectAnswer = q.CorrectAnswer,
                                    Name = q.Name,
                                    CreateTime =q.CreateTime,
                                    LastUpdateTime =q.LastUpdateTime,
                                    Id = q.Id,
                                  }).ToListAsync();
            return new GetListResponseVM<QuestionVM>()
            {
                IsSuccess = true,
                ObjectList = questionList
            };
        }
        public async Task<GetListResponseVM<QuestionVM>> GetQuestionListByIdAsync(int id)
        {
            var questionList = await (from q in _questionRepository.GetAll()
                                      where q.Id == id
                                      select new QuestionVM()
                                      {
                                          Answer1 = q.Answer1,
                                          Answer2 = q.Answer2,
                                          Answer3 = q.Answer3,
                                          Answer4 = q.Answer4,
                                          CorrectAnswer = q.CorrectAnswer,
                                          Name = q.Name,
                                          CreateTime = q.CreateTime,
                                          LastUpdateTime = q.LastUpdateTime,
                                          Id = q.Id,
                                          TopicId=q.TopicId,
                                      }).ToListAsync();
            return new GetListResponseVM<QuestionVM>()
            {
                IsSuccess = true,
                ObjectList = questionList
            };
        }

        public async Task<ResponseVM> UpdateQuestion(QuestionVM questionVM)
        {
            var questionList = _questionRepository.GetAll().Where(a => a.Id == questionVM.Id).FirstOrDefault();
            ResponseVM responseVM = new ResponseVM();
            if (questionVM != null || string.IsNullOrEmpty(questionVM.Name))
            {
                responseVM.Error = new ErrorResponseVM
                {
                    Error = "zorunlu alanları doldurunuz"
                };

            }
            questionList.Answer1 = questionVM.Answer1;
            questionList.Answer2 = questionVM.Answer2;
            questionList.Answer3 = questionVM.Answer3;
            questionList.Answer4 = questionVM.Answer4;
            questionList.CorrectAnswer = questionVM.CorrectAnswer;
            questionList.Name = questionVM.Name;
            questionList.CreateTime = questionVM.CreateTime;
            questionList.LastUpdateTime = DateTime.Now;


            _questionRepository.Update(questionVM.Id,questionList);
            await _questionRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }

        public async Task<GetListResponseVM<QuestionVM>> GetQuestionListByTestIdAsync(int id)
        {
            var questionIdList = await (from q in _questionRepository.GetAll()
                                        join t in _testQuestionRepository.GetAll() on q.Id equals t.QuestionId
                                        where t.TestId==id 
                                        select new QuestionVM()
                                        {
                                            Id = q.Id,
                                            Answer1 = q.Answer1,
                                            Answer2 = q.Answer2,
                                            Answer3 = q.Answer3,
                                            Answer4 = q.Answer4,
                                            CorrectAnswer = q.CorrectAnswer,
                                            CreateTime=q.CreateTime,
                                            LastUpdateTime=q.LastUpdateTime,
                                            Name = q.Name,
                                            TopicId = q.TopicId,
                                        }).ToListAsync();
                            return new GetListResponseVM<QuestionVM>()
                            {
                                IsSuccess = true,
                                ObjectList = questionIdList
                            };
        }
    }
}
