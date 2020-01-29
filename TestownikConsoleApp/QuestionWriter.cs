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
            randomQuestion.Answers.ForEach(answer =>
            {
                Console.WriteLine($"{answer.Answer}");
            });
        }
    }
}