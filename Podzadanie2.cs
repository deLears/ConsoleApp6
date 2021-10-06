using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Podzadanie2
    {
        // Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
        // Определить сумму максимального и минимального элементов массива
        static void Main(string[] args)
        {
            int[] Mss = new int[15];
            Console.WriteLine("Ввод случайным образом 15 чисел массива");
            Random Chis = new Random ();
            for (int i = 0; i < 15; i++)
            {
               Mss[i] = Chis.Next(0, 50);
               Console.Write(Mss[i]);
               Console.Write(" ");
            }
            Console.WriteLine("");
            int Max = Mss.Max();
            int Min = Mss.Min();
            Console.WriteLine("Максимальное число составляет {0}, минимальное число составляет {1}", Max, Min);
            Console.ReadKey();
        }
    }
}
