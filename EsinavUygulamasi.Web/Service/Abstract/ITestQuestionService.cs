using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface ITestQuestionService
    {
        Task<GetListResponseVM<TestQuestion>> GetQuestionListTestById(int testId);
    }
}
