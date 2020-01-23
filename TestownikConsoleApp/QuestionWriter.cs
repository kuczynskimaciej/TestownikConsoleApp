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

            //foreach (QuestionDto question in questions)
            //{
            //    Console.WriteLine(question.Question);
            //    foreach (AnswerDto answer in question.Answers)
            //    {
            //        Console.WriteLine(answer.Answer);
            //    }
            //}

            questions.ForEach(question =>
            {
                Console.WriteLine(question.Question);
                int countOfAnswers = question.Answers.Count();
                question.Answers.ForEach(answer =>
                {
                    Console.WriteLine($"{answer.Answer}");
                });
            });
        }
    }
}
