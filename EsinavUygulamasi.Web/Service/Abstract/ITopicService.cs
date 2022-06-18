using EsinavUygulamasi.DAL.Models.Database;
using EsinavUygulamasi.Models.Request;
using EsinavUygulamasi.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Service.Abstract
{
    public interface ITopicService
    {
        GetListResponseVM<Topic> GetTopicListByFilter(Expression<Func<Topic, bool>> predicate);
        Task<GetListResponseVM<Topic>> GetTopicListByIdAsync(int topicId);
        Task<ResponseVM> AddTopicAsync(Models.Response.TopicVM topicVM);
        Task<ResponseVM> UpdateTopic(TopicVM topicVM);
        Task<ResponseVM> DeleteTopic(TopicVM topicVM);
    }
}
