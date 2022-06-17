using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    public class UserTestInformationView :BaseTableWithOnlyId
    {
        [Column("name")]
        public String Name { get; set; }
        [Column("test_name")]
        public String TestName { get; set; }
        [Column("question_name")]
        public String QuestionName { get; set; }
        [Column("question_answer")]
        public String QuestionAnswer { get; set; }
        [Column("testid")]
        public int TestId { get; set; }
        [Column("status")]
        public bool Status { get; set; }

    }
}
