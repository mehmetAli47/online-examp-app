using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    public class UserInTheTest:BaseTableWithOnlyId
    {
        [Column("test_name")]
        public String TestName { get; set; }
        [Column("number_of_user")]
        public int NumberOfUser { get; set; }
    }
}
