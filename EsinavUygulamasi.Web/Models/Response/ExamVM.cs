using System;
using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Response
{
    public class ExamVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public int InstitutionId { get; set; }
        public String ExamImage { get; set; }
        public  InstitutionVM Institution { get; set; }

       

        public virtual List<QuestionVM> question { get; set; }
    }
}
