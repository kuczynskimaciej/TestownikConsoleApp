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
            var readFile = file.Skip(2).ToList(); //Lista z liniami z pliku
            var question = file[1];

            char[] typeOfAnswers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Console.WriteLine(question);

            readFile.Shuffle<string>();

            var messages = readFile.Select((x, index) =>
            {
                return $"{typeOfAnswers[index]}) {x}";
            }).ToList();

            messages.ForEach(x => Console.WriteLine(x));

            CheckAnswerClass checkAnswer = new CheckAnswerClass();
            checkAnswer.CheckAnswer(path);

            Menu openMenu = new Menu();
            openMenu.menu();
        }
    }
}
