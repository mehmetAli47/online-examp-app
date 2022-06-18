using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface IUserTestSerevice
    {
        Task<ResponseVM> AddTestResult(UserTestVM userTestVM, int id);
       Task<GetListResponseVM<UserTest>> GetUserTestAnswerListById(int userId,int testId);
        Task<ResponseVM> DeleteUserTest(int testid);
        Task<GetListResponseVM<UserTestInformationView>> GetUserTestInformationList(int testId);

    }
}
