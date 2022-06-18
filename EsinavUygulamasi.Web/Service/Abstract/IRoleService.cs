using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface IRoleService
    {
        GetListResponseVM<Role> GetRoleListByFilter(Expression<Func<Role, bool>> predicate);
        List<Role> GetListWithUser();

    }
}
