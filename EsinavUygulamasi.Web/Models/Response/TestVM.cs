using EsinavUygulamasi.DAL.Models.Database;
using System;
using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Response
{
    public class TestVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime StartTime { get; set; }
        public int NumberOfQuestion { get; set; }
        public int ExamId { get; set; }

        public virtual InstitutionVM Institution { get; set; }
        public virtual  IList<QuestionVM> QuestionVM  { get; set; }
        public List<TestQuestion> TestQuestion { get; set; }
        public  List<int> QuestionIdList { get; set; }
        public List<string> QuestinAnswerList { get; set; } 
        
    }
}
