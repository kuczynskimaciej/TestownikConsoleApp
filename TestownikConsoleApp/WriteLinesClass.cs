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
            char[] lineOfAnswers = file[0].ToArray();

            if (lineOfAnswers.Count() != file.Skip(2).Count())
            {
                throw new Exception("Liczba odpowiedzi nie jest zgodna z liczba pytan w pliku");
            }

            var listOfAnswers = file.Skip(2).Select((x, index) =>
            {
                return new KeyValuePair<string, bool>(x, lineOfAnswers[index] == '1' ? true : false);
            }).ToList();

            var question = file[1];

            listOfAnswers.Shuffle();

            char[] typeOfAnswers = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
           
            Console.WriteLine(question);

            var printAnswers = listOfAnswers.Select((x, index) =>
            {
                return new AnswerDto()
                {
                    Type = typeOfAnswers[index].ToString(),
                    Answer = x.Key,
                    IsCorrect = x.Value
                };
            }).ToList();


            printAnswers.ForEach(x => Console.WriteLine($"{x.Type}) {x.Answer}"));

            Console.Write("Wprowadź odpowiedź: ");
            var answer = Console.ReadLine();

            var split = answer.Split(',');

            var selectedAnswers = printAnswers.Where(x => split.Any(y => string.Equals(y, x.Type, StringComparison.InvariantCultureIgnoreCase)));
            if(selectedAnswers.All(x => x.IsCorrect))
            {
                Console.WriteLine("GOOD");
            }
            else
            {
                Console.WriteLine("BAAD");
            }

            Menu openMenu = new Menu();
            openMenu.menu();
        }
    }
}
