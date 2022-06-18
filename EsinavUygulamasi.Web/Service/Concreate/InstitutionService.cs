using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Concreate
{
    public class InstitutionService : IinstitutionService
    {
        IGenericRepository<Institution> _institutionRepository;
        public InstitutionService(IGenericRepository<Institution> instutionRepository)
        {
            _institutionRepository = instutionRepository;
        }

        public async Task<ResponseVM> AddInstitutionAsync(InstitutionVM ınstitutionVM)
        {
            ResponseVM vm = new ResponseVM();
            if (ınstitutionVM == null || string.IsNullOrEmpty(ınstitutionVM.Name))
            {
                vm.Error = new ErrorResponseVM()
                {
                    Error = "Lütfen zorunlu alanları doldurunuz"
                };
            }
            var ınstitutionDb = new Institution()
            {
                Name = ınstitutionVM.Name,
                Address = ınstitutionVM.Address,
                CreateTime = DateTime.Now,
                InstitutionInformation = ınstitutionVM.InstitutionInformation,
                Phone = ınstitutionVM.Phone,
                LastUpdateTime = DateTime.Now
            };
            await _institutionRepository.CreateAsync(ınstitutionDb);
            await _institutionRepository.SaveChangesAsync();
            vm.IsSuccess = true;
            return vm;
        }

        public async Task<ResponseVM> DeleteInstitution(InstitutionVM ınstitutionVM)
        {
            var insDb = _institutionRepository.GetAll().Where(a => a.Id == ınstitutionVM.Id).FirstOrDefault();
            ResponseVM vm = new ResponseVM();
            if(ınstitutionVM==null || string.IsNullOrEmpty(ınstitutionVM.Name))
            {
                vm.Error = new ErrorResponseVM()
                {
                    Error = "Kurum bilgisi Bulunamadı"
                };
            }
            _institutionRepository.Delete(insDb);
            await _institutionRepository.SaveChangesAsync();
            return vm;
        }

        public GetListResponseVM<Institution> GetInstitutionListByFilter(Expression<Func<Institution, bool>> predicate)
        {
            var institution = _institutionRepository.GetAll();
            if (predicate != null)
                institution = institution.Where(predicate);
            var institutionList = institution.ToList();
            return new GetListResponseVM<Institution>()
            {
                IsSuccess = true,
                ObjectList = institutionList
            };
        }

        public async Task<GetListResponseVM<InstitutionVM>> GetInstitutionListByIdAsync(int ınstıtutionId)
        {
            var ınsList = await (from ins in _institutionRepository.GetAll() 
                                      where ins.Id== ınstıtutionId
                                      select new InstitutionVM()
                                      {
                                          Id = ins.Id,
                                          Address = ins.Address,
                                          CreateTime=ins.CreateTime,
                                          InstitutionInformation = ins.InstitutionInformation,
                                          Name = ins.Name,
                                          Phone = ins.Phone,
                                      }).ToListAsync();
            return new GetListResponseVM<InstitutionVM>()
            {
                IsSuccess = true,
                ObjectList = ınsList
            };
        }

        public async Task<ResponseVM> UpdateInstitution(InstitutionVM ınstitutionVM)
        {
            var insList = _institutionRepository.GetAll().Where(a => a.Id == ınstitutionVM.Id).FirstOrDefault();
            ResponseVM responseVM = new ResponseVM();
            if (insList != null || string.IsNullOrEmpty(insList.Name))
            {
                responseVM.Error = new ErrorResponseVM
                {
                    Error = "zorunlu alanları doldurunuz"
                };

            }
            insList.Name = ınstitutionVM.Name;
            insList.InstitutionInformation = ınstitutionVM.InstitutionInformation;
            insList.Address = ınstitutionVM.Address;
            insList.CreateTime = ınstitutionVM.CreateTime;
            insList.LastUpdateTime = DateTime.Now;
            insList.Phone = ınstitutionVM.Phone;

            _institutionRepository.Update(ınstitutionVM.Id, insList);
            await _institutionRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;

        }
    }
}
