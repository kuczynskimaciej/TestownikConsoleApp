using System.Collections.Generic;

namespace TestownikConsoleApp
{
    public class QuestionDto
    {
        public List<AnswerDto> Answers { get; set; }
        public string Question { get; set; }
    }
}
