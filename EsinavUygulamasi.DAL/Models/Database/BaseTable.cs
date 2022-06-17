using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    public class BaseTable:BaseTableWithOnlyId
    {
        
        [Column("name")]
        public string Name { get; set; }
        [Column("create_time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }
        [Column("last_update_time")]
        public DateTime? LastUpdateTime { get; set; }

    }
}
