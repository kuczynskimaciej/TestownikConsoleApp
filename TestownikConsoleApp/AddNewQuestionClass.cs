using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestownikConsoleApp
{
    class AddNewQuestionClass
    {
        public void AddNewQuestion() // to nic nie robi
        {
            string path = @"D:\C#\Programy\TestownikConsoleApp\TestownikConsoleApp\Pytania";
            int fileCount = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;

        }
    }
}
