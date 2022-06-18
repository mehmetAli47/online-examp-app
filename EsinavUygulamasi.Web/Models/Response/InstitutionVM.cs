using System;
using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Response
{
    public class InstitutionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public string InstitutionInformation { get; set; }

        public virtual List<TestVM> Test { get; set; }
        public  List<ExamVM> Exam { get; set; }
    }
}
