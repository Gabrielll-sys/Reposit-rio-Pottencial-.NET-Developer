using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = new List<int>();
            lista.Add(299);

            for (int i = 0;i<100;i++)
            {
                lista.Add(i);
            }

            Console.WriteLine(lista.Contains(10));

        }
    }
}