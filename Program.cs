using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РУБЦОВА_10._1_ПР_21
{
    class Program
    {
        static void Main (string[] args)
        {
            //13VARIANT
            /*  try
              {
                  int n = 6;
                  int m = 13;
                  int[,] a = new int[n, m];
                  Random r = new Random();
                  for (int i = 1; i < a.GetLength(0); i++)
                  {
                      for (int j = 1; j < a.GetLength(1); j++)
                      {
                          if (i == 0)
                              a[0, j] = r.Next(50000, 60000);
                          else
                              a[i, j] = r.Next(30000, 60000);
                          Console.Write($" {a[i, j],8}");
                      }
                      Console.WriteLine();
                  }
                  Console.Write("введите номер сотрудника ");
                  int sot = int.Parse(Console.ReadLine());
                  int z = 0;
                  if (sot > 0 && sot < 6)
                  {
                      for (int j = 1; j < m; j++)
                      {
                          z += a[sot, j];
                      }
                      Console.WriteLine($"общая зарплата {sot} сотрудника за год составляет {z} рублей");
                  }
              }
              catch { Console.WriteLine("вы произвели неправильный ввод"); }*/




            //7 variant
           
            Console.Write("введите кол-во строк  ");
            int m = int.Parse(Console.ReadLine());
            if (m >= 5)
            {
                Console.Write("введите кол-во столбцов: ");
                int n = int.Parse(Console.ReadLine());
                if (n >= 4)
                {
                    int[,] mass = new int[m, n];
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            Console.Write($"число в {j + 1} столбеце {i + 1} строки: ");
                            mass[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("---------------------");
                    }
                   for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            Console.Write($"{mass[i, j],3}");
                        }
                        Console.WriteLine();
                    }                        
                    int sec = 0;
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        if (mass[i, 1] > 15)
                            sec++;
                    }
                    Console.WriteLine($"Количество ненулевых чисел больше 15 во втором столбце: {sec}");                        //2 подпункт
                    int sum5 = 0, kolvo = 0;
                    double sred5 = 0;
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        if (mass[4, j] % 2 != 0)
                        {
                            sum5 += mass[4, j];
                            kolvo++;
                        }
                    }
                    double str5 = sum5 / kolvo;
                    sred5 = Math.Round(str5, 2);
                    Console.WriteLine($"Среднее арифметическое нечётных чисел 5 строки : {sred5}");                        //3 подпункт
                    int sum4 = 0, kolvo4 = 0;
                    double sred4 = 0;
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        if (mass[i, 3] % 4 == 0)
                        {
                            sum4 += mass[i, 3];
                            kolvo4++;
                            Console.Write($"{mass[i, 3],3}");
                        }
                    }
                    double stolb4 = sum4 / kolvo4;
                    sred4 = Math.Round(stolb4, 2);
                    Console.WriteLine($"Среднее арифметическое чисел 4 столбца кратных четырём: {sred4}");
                }
                else
                    Console.WriteLine("Вы произвели неправильный ввод");
            }
            else
                Console.WriteLine("Вы произвели неправильный ввод");


            Console.ReadKey();
        }
    }
}
