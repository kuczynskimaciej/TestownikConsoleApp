using System;
using System.IO;
using System.Linq;


namespace TestownikConsoleApp
{
    class GetPathClass
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

        public string getrandomfile(string path) // publiczne metody  z dużej
        {
            string file = null;
            if (!string.IsNullOrEmpty(path))
            {
                var extensions = new string[] { ".txt" };
                try
                {
                    var di = new DirectoryInfo(path);
                    var rgFiles = di.GetFiles("*.*")
                                    .Where(f => extensions.Contains(f.Extension
                                    .ToLower()));
                    int fileCount = rgFiles.Count();
                    if (fileCount > 0)
                    {
                        int x = this.Generator.Next(0, fileCount);
                        file = rgFiles.ElementAt(x).FullName;
                    }
                }
                catch { } // pusty catch? to jak się coś wywali to rozumiem, że olewamy?
            }

            return file;
        }
    }
}
