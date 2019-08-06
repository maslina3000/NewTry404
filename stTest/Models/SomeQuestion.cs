using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stTest.Models
{
    public class SomeQuestion
    {
        public string Text { get; set; }
        public Guid SessionID { get; set; } = Guid.NewGuid();
       // public int QuestionID { get; set; } = 0;
        public Answer ThisAnswer { get; set; }
    }
}
