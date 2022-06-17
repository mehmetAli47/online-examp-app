using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("user_test")]
    public class UserTest : BaseTableWithOnlyId
    {
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("test_id")]
        public int TestId { get; set; }
        [Column("question_id")]
        public int QuestionId { get; set; }
        [Column("question_answer")]
        public string QuestionAnswer { get; set; }
        [Column("status")]
        public bool Status { get; set; }

        public virtual Test Test { get; set; }
        public virtual Question Question { get; set; }
    }
}
