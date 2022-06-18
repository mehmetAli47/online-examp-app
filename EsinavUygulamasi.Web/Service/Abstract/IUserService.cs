using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface IUserService
    {
        GetListResponseVM<User> GetUserListByFilter(Expression<Func<User, bool>> predicate);
        Task<ResponseVM> AddUserAsync(Models.UserVM userVM);
        Task<ResponseVM> UpdateUserAsync(UserVM user);
        Task<ResponseVM> DeleteUserAsync(UserVM user);
        Task<GetListResponseVM<RoleVM>> GetRoleListByUserIdAsync(int userId);
        Task<GetListResponseVM<UserVM>> GetUserListByIdAsync(int userId);
        GetListResponseVM<UsersTestStatV> GetUsersTestStatByFilter(Expression<Func<UsersTestStatV, bool>> predicate);



    }
}
