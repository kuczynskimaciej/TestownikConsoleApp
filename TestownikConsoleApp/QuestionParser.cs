using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestownikConsoleApp
{
    public class QuestionParser
    {
        public List<QuestionDto> ReadQuestions(string path)
        {
            var directory = new DirectoryInfo(path);
            var questionFiles = directory.GetFiles("*.txt");
            List<QuestionDto> questions = new List<QuestionDto>();
            foreach (var questionFile in questionFiles)
            {
                using (StreamReader sr = File.OpenText(questionFile.))
                {
                    var lines = sr.ReadToEnd()
                }
            }

        }
    }
}
