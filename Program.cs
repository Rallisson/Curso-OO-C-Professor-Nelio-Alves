using System;
using System.Globalization;
using System.Collections.Generic;

namespace OO_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] matriz = new int[m, n]; 

            for (int i = 0; i < m; i++)
            {
                vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i +", " + j + ":");
                        
                        if (i != 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }

                        if(j != 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        
                        if (j != n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }

                        if (i != m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
