using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface ITestService
    {
        GetListResponseVM<Test> GetTestListByFilter(Expression<Func<Test, bool>> predicate);
        Task<GetListResponseVM<TestVM>> GetTestListByExamIdAsync(int id);
        Task<GetListResponseVM<TestVM>> GetTestListByIdAsync(int id);
        Task<ResponseVM> AddTestAsync(TestVM testVM);
        Task<ResponseVM> UpdateTestAsync(TestVM testVM);
        Task<ResponseVM> DeleteTestAsync(TestVM testVM);
        Task<ResponseVM> SaveTest(TestVM testVM);
        GetListResponseVM<UserInTheTest> GetUserInTheTest(Expression<Func<UserInTheTest,bool>> predicate);
        Task<GetListResponseVM<User>> GetUserInTheTestByTestIdAsync(TestVM testVM);
    }
}
