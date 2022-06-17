using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("user_role")]
    public class UserRole:BaseTableWithOnlyId
    {
        
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("role_id")]      
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public User Users { get; set; }
    }
}
