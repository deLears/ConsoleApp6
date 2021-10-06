using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Podzadanie6
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN.
             * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
             * Магическим квадратом называется матрица, сумма элементов которой в каждой строке,
             * в каждом столбце и по каждой диагонали одинакова.
             */
            Console.WriteLine("Введите сторону квадрата массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] Mss = new int[N, N];
            int[] Sstrok = new int[N];
            int[] Sstolb = new int[N];
            int[] Sdiagoi = new int[N];
            int[] Sdiagoj = new int[N];

            // i - строка, j - столбец;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Введите значение ячейки массива с координатами строка №{0}, столбец №{1}", i, j);
                    Mss[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == 0 && j == 0)
                    { Sstrok[j] = Mss[j, i]; }
                    else { Sstrok[j] += Mss[j, i] + Mss[j, i - 1]; }
                }
            }

            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    if (i == 0 && j == 0)
                    { Sstolb[i] = Mss[j, i]; }
                    else { Sstolb[i] += Mss[j, i] + Mss[j - 1, i]; }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == 0 && j == 0)
                    { Sdiagoi[i] = Mss[j, i]; }
                    else { Sdiagoi[i] += Mss[i + 1, j]; }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == 0 && j == 0)
                    { Sdiagoj[j] = Mss[i, j]; }
                    else { Sdiagoi[j] += Mss[i, j + 1]; }
                }
            }
            for (int i = 0; i <= N; i++)
            {
                if (Sstolb[i] == Sstrok[i])
                {
                    if (Sdiagoi[i] == Sdiagoj[i])
                    {
                        if (Sstolb[i] == Sdiagoj[i])
                        {
                            Console.WriteLine("Квадрат является магическим");
                        }
                        else
                        {
                            Console.WriteLine("Квадрат НЕ является магическим");
                        }
                    }

                }
                Console.ReadKey();
            }
        }
        
    }
    
}
