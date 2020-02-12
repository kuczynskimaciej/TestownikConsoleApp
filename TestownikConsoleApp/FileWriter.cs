using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestownikConsoleApp
{
    class WriteFile
    {
        public string path = "Pytania";
        public void AddNewFile()
        {
            int fileCount = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;
            string newFileName = Path.Combine(path, $"{fileCount + 1 + ".txt"}");
            File.CreateText(newFileName);
            AddQuestion();
        }

        public void AddQuestion()
        {
            File.OpenText(path);
            List<QuestionDto> questionList = new List<QuestionDto>();

            QuestionDto newQuestion = new QuestionDto();

        }
    }
}
