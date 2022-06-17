using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("institution")]
    public class Institution:BaseTable
    {
        [Column("address")]
        public string Address { get; set; }
        [Column("institution_information")]
        public string InstitutionInformation { get; set; }
        [Column("phone")]
        public long Phone { get; set; }

        public List<Exam> Exams { get; set; }
    }
}
