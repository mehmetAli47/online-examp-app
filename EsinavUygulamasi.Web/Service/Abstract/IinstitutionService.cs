using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface IinstitutionService
    {
        GetListResponseVM<Institution> GetInstitutionListByFilter(Expression<Func<Institution, bool>> predicate);
        Task<GetListResponseVM<InstitutionVM>> GetInstitutionListByIdAsync(int ınstıtutionId);
        Task<ResponseVM> AddInstitutionAsync(Models.Response.InstitutionVM ınstitutionVM);
        Task<ResponseVM> UpdateInstitution(InstitutionVM ınstitutionVM);
        Task<ResponseVM> DeleteInstitution(InstitutionVM ınstitutionVM);

        
    }
}
