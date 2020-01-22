using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    public class QuestionWriter
    {
        public void WriteQuestions()
        {
            QuestionParser questionParser = new QuestionParser();
            var questions = questionParser.ReadQuestions("Pytania");

        }
    }
}
