﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stTest.Models
{
    public class Question
    {
        public Answer ThisAnswer { get; set; }
        public string Text { get; set; }
    }

    public class TemplateQuestionary
    {
        public Question[] Questions { get; set; }
    }
}
