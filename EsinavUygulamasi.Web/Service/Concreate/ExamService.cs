using EsinavUygulamasi.DAL;
using EsinavUygulamasi.DAL.Models.Database;
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
    public class ExamService : IExamService
    {
        readonly IGenericRepository<Exam> _examsRepository;
        public ExamService(IGenericRepository<Exam> genericRepository)
        {
            _examsRepository = genericRepository;
        }

        public async Task<ResponseVM> AddExam(ExamVM exam)
        {
            ResponseVM responseVM = new ResponseVM();
            if (exam == null)
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "zorunlu alanları doldurunuz"
                };
            }
            var examDb = new Exam()
            {
                Name = exam.Name,
                CreateTime = DateTime.Now,
                LastUpdateTime = DateTime.Now,
                InstitutionId = exam.InstitutionId,
            };
           
            await _examsRepository.CreateAsync(examDb);
            await _examsRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;
        }

        public async Task<ResponseVM> DeleteExam(ExamVM exam)
        {
            var examList = _examsRepository.GetAll().Where(a => a.Id == exam.Id).FirstOrDefault();
            ResponseVM vm = new ResponseVM();
            if (exam == null || string.IsNullOrEmpty(exam.Name))
            {
                vm.Error = new ErrorResponseVM()
                {
                    Error = "Kurum bilgisi Bulunamadı"
                };
            }
            _examsRepository.Delete(examList);
            await _examsRepository.SaveChangesAsync();
            return vm;
        }

        public async Task<GetListResponseVM<ExamVM>> GetExamListByIdAsync(int id)
        {
            var examList = await (from e in _examsRepository.GetAll()
                                  where e.Id == id
                                  select new ExamVM()
                                  {
                                      Id = e.Id,
                                      CreateTime = e.CreateTime,
                                      Name = e.Name,
                                      InstitutionId=e.InstitutionId,
                                  }).ToListAsync();
            return new GetListResponseVM<ExamVM>()
            {
                IsSuccess = true,
                ObjectList = examList
            };
        }

        public async Task<GetListResponseVM<ExamVM>> GetExamListInstitutionByIdAsync(int Id)
        {
            var examList = await (from e in _examsRepository.GetAll()
                                  where e.InstitutionId == Id
                                  select new ExamVM()
                                  {
                                      Id=e.Id,
                                      InstitutionId = e.InstitutionId,
                                      CreateTime=e.CreateTime,
                                      Name=e.Name,
                                  }).ToListAsync();
            return new GetListResponseVM<ExamVM>()
            {
                IsSuccess = true,
                ObjectList = examList
            };
        }

        public GetListResponseVM<Exam> GetExamsListByFilter(Expression<Func<Exam, bool>> predicate)
        {
            var exams = _examsRepository.GetAll();
            if (predicate != null)
                exams = exams.Where(predicate);
            var examsList = exams.ToList();
            return new GetListResponseVM<Exam>()
            {
                IsSuccess = true,
                ObjectList = examsList
            };
        }

        public async Task<ResponseVM> UpdateExam(ExamVM exam)
        {
            var examList = _examsRepository.GetAll().Where(a => a.Id == exam.Id).FirstOrDefault();
            ResponseVM responseVM = new ResponseVM();
            if(examList != null || string.IsNullOrEmpty(examList.Name) || examList.InstitutionId==0)
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "Zorunlu alanları doldurunuz"
                };
            }
            examList.Name = exam.Name;
            examList.CreateTime = exam.CreateTime;
            examList.LastUpdateTime = DateTime.Now;
            examList.InstitutionId=exam.InstitutionId;

            _examsRepository.Update(exam.Id, examList);
            await _examsRepository.SaveChangesAsync();
            responseVM.IsSuccess=true;
            return responseVM;
        }
    }
}
