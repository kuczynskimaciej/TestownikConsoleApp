using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    public class QuestionDto
    {
        public List<AnswerDto> Answers { get; set; }
        public string Question { get; set; }
    }
}
