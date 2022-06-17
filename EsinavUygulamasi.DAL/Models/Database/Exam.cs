using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("exam")]
    public class Exam:BaseTable
    {
        [Column("institution_id")]
        public int InstitutionId { get; set; }
        [Column("exam_image")]
        public string ExamImage { get; set; }

        public  Institution Institution { get; set; }
        public virtual List<Test> Test { get; set; }
       
       
        
    }
}
