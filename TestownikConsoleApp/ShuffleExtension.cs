using System;
using System.Collections.Generic;
using System.Text;

namespace TestownikConsoleApp
{
    public static class ShuffleExtension
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list) // skąd pan to kopiował? :D i czym jest <T>? :D
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n+1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}