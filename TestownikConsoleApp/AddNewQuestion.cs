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
            string path = "Pytania";
            int fileCount = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;

            
        }
    }
}
