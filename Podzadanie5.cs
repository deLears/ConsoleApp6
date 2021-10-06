using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Podzadanie5
    {
        static void Main(string[] args)
        {
            /*
             *Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
             *  1 0 1 0 1
                0 1 0 1 0
                1 0 1 0 1
                0 1 0 1 0
                1 0 1 0 1
            */
            Console.WriteLine("Введите сторону квадрата массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] Mss = new int[N, N];
            // i - строка, j - столбец;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int Code, Coff;
                    Coff = 0;
                    if (N % 2 == 0) Code = 1;
                    else Code = 0;
                    Mss[i, j] = Code;
                    Code = Code + 1;
                    Coff = Coff + 1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i <= N) Console.Write(Mss[i, j]);
                    else
                    {
                        Console.WriteLine();
                        Console.Write(Mss[i, j]);
                    }
                }

            }
            Console.ReadKey();
        }



    }
}

