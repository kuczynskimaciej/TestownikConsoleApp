using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    class Menu
    {
        public void PrintMenu()
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
                        WriteFile readFile = new WriteFile();
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
                        PrintMenu();

                        break;
                }
            }
            else
            {
                Console.Clear();
                PrintMenu();
            }
        }
    }
}

