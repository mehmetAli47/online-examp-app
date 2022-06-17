using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    public class BaseTableWithOnlyId
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
