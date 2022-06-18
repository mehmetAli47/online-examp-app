using EsinavUygulamasi.DAL.Models.Database;
using System;
using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Response
{
    public class UserTestVM
    {
        public int UserId { get; set; }
        public int TestId { get; set; }
        public List<UserTestQuestionAnswer> QuestionAnswerList { get; set; }=new List<UserTestQuestionAnswer>();

    }
    //Kullanıcının hangi soruya hangi cevabı verdiğini tutmak için
    public class UserTestQuestionAnswer
    {
        public int UserId { get; set; }

        public int QuestionId { get; set; }
        public string QuestionAnswer { get; set; }
    }
}
