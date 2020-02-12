using System;
using System.Linq;

namespace TestownikConsoleApp
{
    public class QuestionWriter
    {
        readonly Random rnd = new Random();
        public void WriteQuestions()
        {
            QuestionParser questionParser = new QuestionParser();
            var questions = questionParser.ReadQuestions("Pytania");
            var countOfQuestions = questions.Count();
            var indexOfRndQuestion = rnd.Next(countOfQuestions);
            var randomQuestion = questions[indexOfRndQuestion];
            var countOfAnswers = randomQuestion.Answers.Count();
            Console.WriteLine(randomQuestion.Question);
            randomQuestion.Answers.Shuffle();
            var answers = randomQuestion.Answers.Select((answer, index) => new { indexOfAnswer = index + 1, answer.Answer });
            foreach (var x in answers)
            {
                Console.WriteLine($"{x.indexOfAnswer}) {x.Answer}");
            }
        }
    }
}