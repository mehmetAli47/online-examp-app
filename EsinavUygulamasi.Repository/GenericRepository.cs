using EsinavUygulamasi.DAL;
using EsinavUygulamasi.DAL.Models.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Repository
{
    public class GenericRepository<T>: IGenericRepository<T> where T:BaseTableWithOnlyId
    {
        private readonly EsinavUygulamasiDbContext _dbContext;

        public GenericRepository(EsinavUygulamasiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().OrderBy(s=>s.Id);
        }
        public List<T> GetListAll(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }

        /// <summary>
        /// bu işlem nesne oluşturmada kullanılır
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public  void Update(int id, T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        

        public  void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        
    }
}
