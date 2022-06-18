using System;
using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Response
{
    public class TopicVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public  List<QuestionVM> question { get; set; }

    }
}
