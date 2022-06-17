using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("test")]
    public class Test:BaseTable
    {
        [Column("start_time")]
        public DateTime StartTime { get; set; }
        [Column("numberof_question")]
        public int NumberOfQuestion { get; set; }
        [Column("exam_id")]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        public List<TestQuestion> TestQuestions { get; set; }
        public IList<UserTest> UserTest { get; set; }
        

    }
}
