using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestownikConsoleApp
{
    class CheckAnswerClass
    {
        public void CheckAnswer(string path)
        {
            var file = File.ReadAllLines(path);
            var indexOfCorrectAnswer = file.First().IndexOf('1');
            var countOfAnswers = file.Skip(2).Count();
            Console.Write("Odp: ");
            var x = Convert.ToString(Console.ReadLine());
           
            //if (x == indexOfCorrectAnswer)
            //{
            //    Console.WriteLine("Poprawna odpowiedź");
            //}
            //else
            //{
            //    Console.WriteLine("źle, jeszcze raz");
            //    CheckAnswer(path);
            //}
        }
    }
}
