using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestownikConsoleApp
{
    public class QuestionWriter
    {
        public void WriteQuestions()
        {
            QuestionParser questionParser = new QuestionParser();
            var questions = questionParser.ReadQuestions("Pytania");

            questions.ForEach(x => Console.WriteLine(x.Question));
            questions.ForEach(x => x.Answers.ForEach(y => Console.WriteLine(y.Answer)));
        }
    }
}
