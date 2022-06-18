
using EsinavUygulamasi.Models.Response;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EsinavUygulamasi.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }


        public List<RoleVM> Role { get; set; } = new List<RoleVM>();
        public List<int> RoleIdList { get; set; } = new List<int>();
    }
}
