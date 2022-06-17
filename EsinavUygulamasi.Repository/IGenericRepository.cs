using EsinavUygulamasi.DAL.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Repository
{
    public interface IGenericRepository<T> where T:BaseTableWithOnlyId
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        /// <summary>
        ///  bu işlem nesne oluşturmada kullanılır
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task CreateAsync(T entity);
       
        void Update(int id, T entity);

        
        void Delete(T entity);

        List<T> GetListAll(Expression<Func<T, bool>> predicate);
        Task<int> SaveChangesAsync();

    }
}
