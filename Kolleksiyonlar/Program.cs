using System;
using System.Collections.Generic;

namespace Kolleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("İlker");

            foreach (var item in isimler2)
            {
                Console.WriteLine(isimler2);
            }
        }
    }
}
