using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestownikConsoleApp
{
    class AddNewQuestionClass
    {
        public void AddNewQuestion()
        {
            string path = @"D:\C#\Programy\TestownikConsoleApp\TestownikConsoleApp\Pytania";
            int fileCount = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;

            var newFile = $@"D:\C#\Programy\TestownikConsoleApp\TestownikConsoleApp\Pytania\{fileCount+1}.txt"; //jakieś gówno
        }
    }
}
