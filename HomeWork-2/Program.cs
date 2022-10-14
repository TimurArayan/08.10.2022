using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Program
    {
        static void Sravnenie(int[] a, int[] b)
        {
            int a1 = 0;
            int b1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 5)
                {
                    a1 += 1;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 5)
                {
                    b1 += 1;
                }
            }
            if (a1 == b1)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("«Ой, Бьорг - пончик! Ни для кого пива!");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2");
            int[] firstcommand = { 1, 2, 3, 4, 5 };
            int[] secondcommand = { 1, 2, 3, 4, 5, 1};
            Sravnenie(firstcommand, secondcommand);
            
        }
    }
}
