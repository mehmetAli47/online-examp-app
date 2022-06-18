using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using EsinavUygulamasi.Repository;
using EsinavUygulamasi.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Concreate
{
    public class TestQuestionService : ITestQuestionService
    {
        IGenericRepository<TestQuestion> _testQuestionRepository;

        public TestQuestionService(IGenericRepository<TestQuestion> testQuestionRepository)
        {
            _testQuestionRepository = testQuestionRepository;
        }

        public async Task<GetListResponseVM<TestQuestion>> GetQuestionListTestById(int testId)
        {
            var testQuestions = await (from tq in _testQuestionRepository.GetAll()
                                       where tq.TestId == testId
                                       select new TestQuestion()
                                       {
                                           Id = tq.Id,
                                           TestId = tq.TestId,
                                           QuestionId = tq.QuestionId
                                       }
                               ).ToListAsync();
            if (testQuestions != null)
            {
                for (var i = 0; i < testQuestions.Count; i++)
                {
                    _testQuestionRepository.Delete(testQuestions[i]);
                    await _testQuestionRepository.SaveChangesAsync();
                }
            }
                return new GetListResponseVM<TestQuestion>()
            {
                IsSuccess = true,
                ObjectList = testQuestions
            };

        }
    }
}
