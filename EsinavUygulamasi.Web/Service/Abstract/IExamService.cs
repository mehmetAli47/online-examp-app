using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface IExamService
    {
        GetListResponseVM<Exam> GetExamsListByFilter(Expression<Func<Exam, bool>> predicate);
        Task<GetListResponseVM<ExamVM>> GetExamListByIdAsync(int id);
        Task<GetListResponseVM<ExamVM>> GetExamListInstitutionByIdAsync(int Id);
        Task<ResponseVM> AddExam(ExamVM exam);
        Task<ResponseVM> UpdateExam(ExamVM exam);
        Task<ResponseVM> DeleteExam(ExamVM exam);

    }
}
