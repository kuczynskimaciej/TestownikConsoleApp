using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    class Menu
    {
        public void menu()
        {

            Console.WriteLine("1 - Losuj");
            Console.WriteLine("2 - Wyjdź");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        GetPathClass getPath = new GetPathClass();
                        string path = getPath.getrandomfile(@"D:\C#\Programy\TestownikConsoleApp\TestownikConsoleApp\Pytania");
                        WriteLinesClass readFile = new WriteLinesClass();
                        readFile.WriteLines(path);

                        Console.ReadLine();

                        break;
                    case 2:
                        Environment.Exit(0);

                        break;
                }
                if (caseSwitch == 0 || caseSwitch > 2)
                {
                    Console.Clear();
                    menu();
                }
                else Environment.Exit(0);
            }
            catch
            {
                //Console.Clear();
                Console.WriteLine("~~~Wprowadź cyfrę!~~~\n");
                menu();
            }
        }
    }
}
