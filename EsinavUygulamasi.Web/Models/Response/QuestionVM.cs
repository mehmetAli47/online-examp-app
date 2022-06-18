using System;
using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Response
{
    public class QuestionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4  { get; set; }
        public string  CorrectAnswer { get; set; }
        public int TopicId { get; set; }
        public List<int> TopicIdList { get; set; }
        public virtual  TopicVM Topic { get; set; }
        public virtual TestVM   Test { get; set; }
        public virtual ExamVM Exam { get; set; }

        


    }
}
