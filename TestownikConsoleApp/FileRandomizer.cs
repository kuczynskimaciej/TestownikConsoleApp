using System;
using System.IO;
using System.Linq;


namespace TestownikConsoleApp
{
    class FileRandomizer
    {
        private Random generator;
        private Random Generator
        {
            get
            {
                if (this.generator == null)
                {
                    this.generator = new Random();
                }
                return this.generator;
            }
        }

        public string GetRandomFile(string path)
        {
            string file = null;
            if (!string.IsNullOrEmpty(path))
            {
                var extensions = new string[] { ".txt" };
                var di = new DirectoryInfo(path);
                var rgFiles = di.GetFiles("*.*")
                                .Where(f => extensions.Contains(f.Extension
                                .ToLower()));
                int fileCount = rgFiles.Count();
                if (fileCount > 0)
                {
                    int rndNubmerOfFile = this.Generator.Next(0, fileCount);
                    file = rgFiles.ElementAt(rndNubmerOfFile).FullName;
                }
            }
            return file;
        }
    }
}
