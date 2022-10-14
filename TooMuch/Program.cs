using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace TooMuch
{
    internal class Program
    {
        static void Task_1(string s)
        {
            int kgl = 0;
            int ksogl = 0;
            string glasn = "eyuioa";
            string sogl = "qwrtpsdfghjklzxcvbnm";
            for (int i =0; i < s.Length; i++)
            {
                if (glasn.Contains(s[i]))
                {
                    kgl++;
                }
                else if (sogl.Contains(s[i]))
                {
                    ksogl++;
                }
            }
            Console.WriteLine($"Гласных: {kgl}, согласных: {ksogl}");
        }

        static void Task_4(string s)
        {
            char[] c4 = s.ToCharArray();
            int kgl = 0;
            int ksogl = 0;
            string glasn = "eyuioa";
            string sogl = "qwrtpsdfghjklzxcvbnm";
            foreach (char ch in c4)
            {
                if (glasn.Contains(ch))
                {
                    kgl++;
                }
                else if (sogl.Contains(ch))
                {
                    ksogl++;
                }
            }
            Console.WriteLine($"Гласных: {kgl}, согласных: {ksogl}");
        }

        static int[,] Task_2_1(int[,] matr1, int[,] matr2)
        {
            Console.WriteLine("Task 2");
            int len1_0 = matr1.GetLength(0);  
            int len1_1 = matr1.GetLength(1);
            int len2_0 = matr2.GetLength(0); 
            int len2_1 = matr2.GetLength(1);

            if (len1_1 == len2_0)
            {
                int[,] new_matr = new int[len1_0, len2_1];

                for (int i = 0; i < len1_0; i++)
                {
                    for (int j = 0; j < len2_1; j++)
                    {
                        for (int k = 0; k < len1_1; k++)
                        {
                            new_matr[i, j] += matr1[i, k] * matr2[k, j];
                        }
                    }
                }
                return new_matr;
            }
            else
            {
                Console.WriteLine("Число столбцов в первом сомножителе должно быть равно числу строк во втором");
                return null;
            }
        }
        static void Task_2_2(int[,] matr)
        {
            int len0 = matr.GetLength(0);
            int len1 = matr.GetLength(1);
            for (int i = 0; i < len0; i++)
            {
                for (int j = 0; j < len1; j++)
                {
                    Console.Write(matr[i,j] + " ");
                }
                Console.Write("\n");
            }
        }
        static void Task_3(int[,] matr)
        {
            var dict = new Dictionary<string, double>();
            string[] months = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            List<double> t = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                int summa = 0;
                for (int j = 0; j < 30; j++)
                {
                    summa += matr[i, j];
                }
                double avg = summa / 30;
                string month = months[i];
                dict.Add(month, avg);
                t.Add(avg);
                t.Sort();
                
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write(t[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < 12; i++)
            {
                string month = months[i];
                Console.WriteLine(months[i] + ": " + dict[month]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            StreamReader stroka1 = new StreamReader("C:\\Users\\timur\\Desktop\\test.txt");
            string s1 = stroka1.ReadLine();
            Task_1(s1);

            Console.WriteLine("Задача 4");
            StreamReader stroka4 = new StreamReader("C:\\Users\\timur\\Desktop\\test.txt");
            string s4 = stroka4.ReadLine();
            Task_4(s4);

            Console.WriteLine("Задача 2");
            int[,] mat1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] mat2 = new int[2, 2] { { 5, 6 }, { 7, 8 } };
            Task_2_2(Task_2_1(mat1, mat2));

            Console.WriteLine("Задача 3, 6");
            int[,] temperature = new int[12, 30];

            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = random.Next(-30, 30);
                }
            }
            Task_3(temperature);




        }
    }
}
