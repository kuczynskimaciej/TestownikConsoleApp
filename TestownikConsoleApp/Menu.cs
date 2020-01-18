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
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            GetPathClass getPath = new GetPathClass();
            string path = getPath.GetRandomFile("Pytania");

            try
            {
                switch (caseSwitch)
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
                }
                if (caseSwitch == 0 || caseSwitch > 2)
                {
                    Console.Clear();
                    Menu();
                }
                else Environment.Exit(0);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("~~~Wprowadź cyfrę!~~~\n");
                Menu();
            }
        }
    }
}
