using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestownikConsoleApp
{
    class WriteLinesClass
    {

        public void WriteLines(string path)
        {
            var file = File.ReadAllLines(path);
            var listOfAnswers = file.Skip(2).ToList();
            var listOfCorrectAnswers = file.First().ToList();
            var indexes = Enumerable.Range(1, listOfCorrectAnswers.Count()).ToList();

            var question = file[1];

            char[] typeOfAnswers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            indexes.Shuffle<int>();

            Console.WriteLine(question);

            var printAnswers = indexes.Select((x, index) =>
            {
                return $"{typeOfAnswers[index]}) {listOfAnswers[x - 1]}";
            }).ToList();

            printAnswers.ForEach(x => Console.WriteLine(x));

            var checkCorrectAnswer = indexes.Select((x, index) =>
            {
                return listOfCorrectAnswers[x-1];
            }).ToList();

            
            //var checkAnswer = Console.ReadLine();
            var indexOfCorrectAnswer = checkCorrectAnswer.IndexOf('1');
            var indexOfTypeOfAnswer = typeOfAnswers[indexOfCorrectAnswer];

            Console.WriteLine(indexOfCorrectAnswer);
            Console.WriteLine(indexOfTypeOfAnswer);

            
            Menu openMenu = new Menu();
            openMenu.menu();
        }
    }
}
