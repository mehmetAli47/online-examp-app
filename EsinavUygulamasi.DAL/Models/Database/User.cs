using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("user")]
    public class User : BaseTable
    {
        [Column("surname")]
        public string Surname { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("user_name")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        public List<UserRole> userRoles { get; set; }

        public virtual UserRole UserRole { get; set; }
        public IList<UserTest> UserTest { get; set; }
    }
}
