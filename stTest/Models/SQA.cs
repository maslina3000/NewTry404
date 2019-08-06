using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stTest.Models
{
    public class SQA:Answer
    {
        public SomeQuestion ASomeQuestion { get; set; }
        public Answer QAnswer { get; set; }
        public int QuestionId { get; set; } = 1;
    }
}
