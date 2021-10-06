using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Podzadanie3
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            int[] Mss = new int[10];
            Console.WriteLine("Ввод случайным образом 10 чисел массива");
            Random Chis = new Random();
            for (int i = 0; i < 10; i++)
            {
                Mss[i] = Chis.Next(-50, 50);
                Console.Write(Mss[i]);
                Console.Write(" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Первые 5 элементов упорядочены по возрастанию как");
            for (int i = 0; i < 5; i++)
            {
                int t;
                if (Mss[i] > Mss[i + 1])
                    {
                    t = Mss[i+1];
                    Mss[i + 1] = Mss[i];
                    Mss[i] = t;
                        }
                Console.WriteLine(Mss[i]);

            }

            Console.WriteLine("Вторые 5 элементов упорядочены по убыванию как");
            for (int i = 5; i < 10; i++)
            {
                int t;
                if (Mss[i] < Mss[i + 1])
                {
                    t = Mss[i + 1];
                    Mss[i + 1] = Mss[i];
                    Mss[i] = t;
                }
                Console.WriteLine(Mss[i]);

            }


            int Max = Mss.Max();
            int Min = Mss.Min();
            Console.WriteLine("Максимальное число составляет {0}, минимальное число составляет {1}", Max, Min);
            Console.ReadKey();
        }
    }
}
