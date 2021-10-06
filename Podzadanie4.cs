using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Podzadanie4
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.
            int[] Mss = new int[20];
            Console.WriteLine("Ввод случайным образом 20 чисел массива");
            Random Chis = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mss[i] = Chis.Next(-50, 50);
                Console.Write(Mss[i]);
                Console.Write(" ");
            }
            int Summ = 0;
            for (int i = 0; i < 20; i++)
            {
                double ostatEl, ostatNum;
                ostatEl = Mss[i] % 2;
                ostatNum = i % 2;
                if (ostatEl!=0)
                    if (ostatNum == 0)
                        Summ++;
            }
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0}", Summ);
            Console.ReadKey();
        }
    }
}
