using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsinavUygulamasi.DAL.Models.Database
{
    [Table("question")]
    public class Question:BaseTable
    {
        [Column("answer1")]
        public string Answer1 { get; set; }
        [Column("answer2")]
        public string Answer2 { get; set; }
        [Column("answer3")]
        public string Answer3 { get; set; }
        [Column("answer4")]
        public string Answer4 { get; set; }
        [Column("correct_answer")]
        public string CorrectAnswer { get; set; }
        [Column("topic_id")]
        public int TopicId { get; set; }
       
        public Topic Topic { get; set; }
        public IList<TestQuestion> TestQuestions { get; set; }
        public IList<UserTest> UserTest { get; set; }

    }
}
