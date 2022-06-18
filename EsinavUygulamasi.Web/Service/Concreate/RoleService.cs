using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EsinavUygulamasi.Service.Concreate
{
    public class RoleService : IRoleService
    {
       readonly IGenericRepository<Role> _roleRepository;

        public RoleService(IGenericRepository<Role> genericRepository)
        {
            _roleRepository=genericRepository;
        }

        public List<Role> GetListWithUser()
        {
            return _roleRepository.GetAll().Include(a=>a.userRoles).ToList();
        }

        public GetListResponseVM<Role> GetRoleListByFilter(Expression<Func<Role, bool>> predicate)
        {
            var role = _roleRepository.GetAll();
            if(predicate != null)
               role = role.Where(predicate);
            var roleList = role.ToList();
            return new GetListResponseVM<Role>()
            {
                IsSuccess = true,
                ObjectList = roleList
            };
        }
    }
}
