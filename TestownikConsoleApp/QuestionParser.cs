using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestownikConsoleApp
{
    public class QuestionParser
    {
        public List<QuestionDto> ReadQuestions(string path)
        {
            string[] questionFiles = Directory.GetFiles(path);
            List<QuestionDto> questions = new List<QuestionDto>();
            foreach (var questionFile in questionFiles)
            {
                string[] lines = File.ReadAllLines(questionFile);
                if (lines.Length < 4)
                {
                    Console.WriteLine("Niepoprawna ilość odpowiedzi");
                    continue;
                }

                QuestionDto question = new QuestionDto();
                question.Question = lines[1];
                var answersPointers = lines[0].ToCharArray();
                var answerLines = lines.Skip(2).ToArray();

                if (answersPointers.Length != answerLines.Length)
                {
                    Console.WriteLine("Niezgodna ilośc opdowiedzi");
                    continue;
                }

                question.Answers = new List<AnswerDto>();
                for (int i = 0; i < answerLines.Length; i++)
                {
                    string answerLine = answerLines[i];
                    string result = answersPointers[i].ToString();
                    var answer = new AnswerDto();
                    answer.Answer = answerLine;
                    answer.IsCorrect = result == "1";
                    question.Answers.Add(answer);
                }

                questions.Add(question);

            }
            return questions;
        }
    }
}