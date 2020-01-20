using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestownikConsoleApp
{
    class WriteLinesClass
    {
        public void WriteLines(string path)
        {
            MenuClass openMenu = new MenuClass();

            var file = File.ReadAllLines(path);
            char[] lineOfAnswers = file[0].ToArray();

            if (lineOfAnswers.Count() != file.Skip(2).Count())
            {
                Console.WriteLine($"Błąd w pliku: \n\n{path}\n");
                Console.WriteLine("Liczba odpowiedzi nie jest zgodna z liczba znaczników odpowiedzi w pliku.");
                Console.ReadLine();
                Console.Clear();
                openMenu.Menu();
            }

            var listOfAnswers = file.Skip(2).Select((x, index) =>
            {
                return new KeyValuePair<string, bool>(x, lineOfAnswers[index] == '1' ? true : false);
            }).ToList();

            var question = file[1];

            listOfAnswers.Shuffle();

            int countOfAnswers = file.Skip(2).Count();

            char[] typeOfAnswers = Enumerable.Range('A', countOfAnswers).Select(x => (char)x).ToArray();

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
            string answer = Console.ReadLine();

            var split = answer.Split(',');

            var selectedAnswers = printAnswers.Where(x => split.Any(y => string.Equals(y, x.Type, StringComparison.InvariantCultureIgnoreCase)));

            if (selectedAnswers.Any(x => printAnswers.Any(y => y.Type == x.Type))) 
                {
                    if (selectedAnswers.All(x => x.IsCorrect))
                    {
                        Console.WriteLine("GOOD");
                    }
                    else
                    {
                        Console.WriteLine("BAAD");
                    }
                }
                else 
                {
                    Console.WriteLine("Zły znak, wprowadź odpowiedź!");
                }


            Console.WriteLine();
            openMenu.Menu();
        }
    }
}
