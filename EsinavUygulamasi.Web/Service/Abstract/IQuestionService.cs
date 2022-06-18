using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface IQuestionService
    {
        GetListResponseVM<Question> GetQuestionListByFilter(Expression<Func<Question, bool>> predicate);
        Task<GetListResponseVM<QuestionVM>> GetQuestionListByTopicIdAsync(int id);
        Task<GetListResponseVM<QuestionVM>> GetQuestionListByTestIdAsync(int id);
        Task<GetListResponseVM<QuestionVM>> GetQuestionListByIdAsync(int id);
        Task<ResponseVM> AddQuestionAsync(Models.Response.QuestionVM questionVM);
        Task<ResponseVM> UpdateQuestion(QuestionVM questionVM );
        Task<ResponseVM> DeleteQuestion(QuestionVM  questionVM);
        //Task<ResponseVM> AddTestQuestion(Models.Response.QuestionVM questionVM);
    }
}
