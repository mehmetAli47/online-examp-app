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
    public class UserService : IUserService
    {
        IGenericRepository<User> _userRepository;
        IGenericRepository<Role> _roleRepository;
        IGenericRepository<UserRole> _userRoleRepository;
        IGenericRepository<UsersTestStatV> _usersTestStatRepository;
        public UserService(IGenericRepository<User> userRepository, IGenericRepository<Role> roleRepository,
            IGenericRepository<UserRole> userRoleRepository, IGenericRepository<UsersTestStatV> usersTestStatRepository
            )
        {

            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _usersTestStatRepository= usersTestStatRepository;

        }



        /// <summary>
        /// istenilen filtrey göre kullanıcı listesi döndrür
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public GetListResponseVM<User> GetUserListByFilter(Expression<Func<User, bool>> predicate)
        {
            var userQuery = _userRepository.GetAll();
            if (predicate != null)
                userQuery = userQuery.Where(predicate);
            var userList = userQuery.ToList();
            return new GetListResponseVM<User>()
            {
                IsSuccess = true,
                ObjectList = userList
            };
        }

        public GetListResponseVM<UsersTestStatV> GetUsersTestStatByFilter(Expression<Func<UsersTestStatV, bool>> predicate)
        {
            var testStat = _usersTestStatRepository.GetAll();
            if (predicate != null)
                testStat = testStat.Where(predicate);
            var testStatList = testStat.ToList();
            return new GetListResponseVM<UsersTestStatV>()
            {
                IsSuccess = true,
                ObjectList = testStatList
            };
        }

        /// <summary>
        /// Kullanıcı id'sine göre kullanıcının rol bilgisini getir
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<GetListResponseVM<RoleVM>> GetRoleListByUserIdAsync(int userId)
        {
            var userRoleList = await (from ur in _userRoleRepository.GetAll()
                                      join r in _roleRepository.GetAll() on ur.RoleId equals r.Id
                                      where ur.UserId == userId
                                      select new RoleVM()
                                      {
                                          Id = r.Id,
                                          Name = r.Name
                                      }).ToListAsync();
            return new GetListResponseVM<RoleVM>()
            {
                IsSuccess = true,
                ObjectList = userRoleList
            };
        }

        /// <summary>
        /// Gelen kullanıcı Id sine göre kullanıcı bilgilerini getirir
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>

        public async Task<GetListResponseVM<UserVM>> GetUserListByIdAsync(int userId)
        {
            var userList = await (from u in _userRepository.GetAll()
                                  where u.Id == userId
                                  select new UserVM()
                                  {
                                      Id = u.Id,
                                      Name = u.Name,
                                      SurName = u.Surname,
                                      Email = u.Email,
                                      UserName = u.Username,
                                      Password = u.Password,
                                      CreateTime = u.CreateTime,
                                      LastUpdateTime = DateTime.Now,
                                  }).ToListAsync();
            return new GetListResponseVM<UserVM>()
            {
                IsSuccess = true,
                ObjectList = userList
            };
        }
        /// <summary>
        /// kullanıcı ekleme işlemi
        /// </summary>
        /// <param name="userVM"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ResponseVM> AddUserAsync(UserVM userVM)
        {
            ResponseVM responseDt = new ResponseVM();
            if (userVM == null || string.IsNullOrEmpty(userVM.Name))
            {
                responseDt.Error = new ErrorResponseVM()
                {
                    Error = "Lütfen zorunlu alanları doldurunuz"
                };
            }
            var usersDb = new User()
            {
                CreateTime = DateTime.Now,
                Name = userVM.Name,
                Surname = userVM.SurName,
                Password = userVM.Password,
                Username = userVM.UserName,
                Email = userVM.Email,
                LastUpdateTime = DateTime.Now,
            };
            await _userRepository.CreateAsync(usersDb);
            await _userRepository.SaveChangesAsync();
            responseDt.IsSuccess = true;
            return responseDt;
        }
        /// <summary>
        /// kullanıcı bilgilerinin güncellenmesi
        /// </summary>
        /// <param name="userVM"></param>
        /// <returns></returns>
        public async Task<ResponseVM> UpdateUserAsync(UserVM user)
        {
            var userDb = _userRepository.GetAll().Where(a => a.Id == user.Id).FirstOrDefault();
            ResponseVM responseDt = new ResponseVM();
            if (user == null || string.IsNullOrEmpty(user.Name))
            {
                responseDt.Error = new ErrorResponseVM()
                {
                    Error = "Zorunlu Alanları doldurun"
                };
            }
            userDb.Name = user.Name;
            userDb.Surname = user.SurName;
            userDb.Password = user.Password;
            userDb.Username = user.UserName;
            userDb.Email = user.Email;
            userDb.CreateTime = user.CreateTime;
            userDb.LastUpdateTime = DateTime.Now;


            _userRepository.Update(user.Id, userDb);
            await _userRepository.SaveChangesAsync();
            responseDt.IsSuccess = true;
            return responseDt;
        }
        /// <summary>
        /// Kulanıcı bilgisini silme işlemi 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ResponseVM> DeleteUserAsync(UserVM user)
        {
            var userDb = _userRepository.GetAll().Where(a => a.Id == user.Id).FirstOrDefault();
            ResponseVM responseDt = new ResponseVM();
            if (user == null || string.IsNullOrEmpty(user.Name))
            {
                responseDt.Error = new ErrorResponseVM()
                {
                    Error = "Kullanıcı bilgisi bulunamadı"
                };
            }
            _userRepository.Delete(userDb);
            await _userRepository.SaveChangesAsync();
            return responseDt;
        }
    }
}
