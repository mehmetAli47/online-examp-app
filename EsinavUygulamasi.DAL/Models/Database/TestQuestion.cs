using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("test_question")]
    public class TestQuestion:BaseTableWithOnlyId
    {
        [Column("test_id")]
        public int TestId { get; set; }

        [Column("question_id")]
        public int QuestionId { get; set; }

        public virtual Test Tests{ get; set; }
        public virtual Question Questions { get; set; }
    }
}
