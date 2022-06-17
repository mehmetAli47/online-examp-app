using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    public class UsersTestStatV:BaseTableWithOnlyId
    {
        [Column("user_name")]
        public String UserName { get; set; }
        [Column("name")]
        public String TestName { get; set; }
        [Column("number_of_correct")]
        public int NumberOfCorrect { get; set; }
        [Column("number_of_wrong")]
        public int NumberOfWrong { get; set; }
        [Column("number_of_useranswer")]
        public int numberOfUserAnswer { get; set; }

        [Column("test_id")]
        public int TestId { get; set; }
    }
}
