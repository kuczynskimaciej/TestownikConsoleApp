using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    class MenuClass
    {
        public void Menu()
        {

            Console.WriteLine("1 - Losuj");
            Console.WriteLine("2 - Dodaj Pytanie");
            Console.WriteLine("3 - Wyjdź");
            GetPathClass getPath = new GetPathClass();
            string path = getPath.GetRandomFile("Pytania");

            var selectedNumber = Console.ReadLine();
            int number;

            bool success = Int32.TryParse(selectedNumber, out number);

            if (success)
            {
                switch (number)
                {
                    case 1:
                        Console.Clear();
                        WriteLinesClass readFile = new WriteLinesClass();
                        readFile.WriteLines(path);

                        break;

                    case 2:
                        Console.Clear();
                        AddNewQuestionClass writeFile = new AddNewQuestionClass();
                        writeFile.AddNewQuestion();

                        break;
                    case 3:
                        Environment.Exit(0);

                        break;
                    default:
                        Console.Clear();
                        Menu();

                        break;
                }
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }
    }
}

