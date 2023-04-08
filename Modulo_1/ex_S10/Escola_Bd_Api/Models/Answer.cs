using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public string AnswerText { get; set; }
        public byte[] Image { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }
        public Question Question { get; set; }
        public Student Student { get; set; }
    }
}