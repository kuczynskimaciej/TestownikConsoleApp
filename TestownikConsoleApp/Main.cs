using System;

namespace TestownikConsoleApp
{
    class Program
    {
        static void Main()
        {
            //Menu openMenu = new Menu();
            //openMenu.PrintMenu();
            QuestionWriter writeQuestion = new QuestionWriter();
            writeQuestion.WriteQuestions();

            Console.ReadLine();
        }
    }
}