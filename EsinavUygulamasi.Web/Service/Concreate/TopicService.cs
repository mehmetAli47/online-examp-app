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
    public class TopicService : ITopicService
    {
        readonly IGenericRepository<Topic> _topicRepository;

        public TopicService(IGenericRepository<Topic> topicRepository)
        {
            _topicRepository = topicRepository;
        }

        public async Task<ResponseVM> AddTopicAsync(TopicVM topicVM)
        {
            ResponseVM vm = new ResponseVM();
            if (topicVM == null || string.IsNullOrEmpty(topicVM.Name))
            {
                vm.Error = new ErrorResponseVM()
                {
                    Error = "Lütfen zorunlu alanları doldurunuz"
                };
            }

            var topicList = new Topic()
            {
                Name = topicVM.Name,
                CreateTime = DateTime.Now,
                LastUpdateTime = DateTime.Now,
            };
            await _topicRepository.CreateAsync(topicList);
            await _topicRepository.SaveChangesAsync();
            vm.IsSuccess = true;
            return vm;
        }

        public async Task<ResponseVM> DeleteTopic(TopicVM topicVM)
        {
            var topicValue = _topicRepository.GetAll().Where(a => a.Id == topicVM.Id).FirstOrDefault();
            ResponseVM responseVM = new ResponseVM();
            if (topicVM == null || string.IsNullOrEmpty(topicVM.Name))
            {
                responseVM.Error = new ErrorResponseVM()
                {
                    Error = "Konu bilgisi Bulunamadı"
                };
            }
            _topicRepository.Delete(topicValue);
            await _topicRepository.SaveChangesAsync();
            return responseVM;
        }

        public GetListResponseVM<Topic> GetTopicListByFilter(Expression<Func<Topic, bool>> predicate)
        {
            var values = _topicRepository.GetAll();
            if (predicate != null)
                values = values.Where(predicate);
            var topicList = values.ToList();
            return new GetListResponseVM<Topic>()
            {
                IsSuccess = true,
                ObjectList = topicList
            };
        }

        public async Task<GetListResponseVM<Topic>> GetTopicListByIdAsync(int topicId)
        {
            var topicList =await (from t in _topicRepository.GetAll()
                             where t.Id == topicId
                             select new Topic()
                             {
                                Id= t.Id,
                                Name= t.Name,
                                CreateTime = t.CreateTime,
                                LastUpdateTime = t.LastUpdateTime,
                             }).ToListAsync();
            return new GetListResponseVM<Topic>()
            {
                IsSuccess = true,
                ObjectList = topicList
            };
        }

        public async Task<ResponseVM> UpdateTopic(TopicVM topicVM)
        {
            var topicList = _topicRepository.GetAll().Where(a => a.Id == topicVM.Id).FirstOrDefault();
            ResponseVM responseVM = new ResponseVM();
            if (topicVM != null || string.IsNullOrEmpty(topicVM.Name))
            {
                responseVM.Error = new ErrorResponseVM
                {
                    Error = "zorunlu alanları doldurunuz"
                };

            }
            topicList.Name=topicVM.Name;
            topicList.CreateTime = topicVM.CreateTime;
            topicList.LastUpdateTime = DateTime.Now;

            _topicRepository.Update(topicVM.Id,topicList);
            await _topicRepository.SaveChangesAsync();
            responseVM.IsSuccess = true;
            return responseVM;

        }
    }
}
