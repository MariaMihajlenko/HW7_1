﻿//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
using System;
class Program
{
    static void Main()
    {
        double[,] a = new double[3, 4];
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)

            {
                a[i, j] = random.Next(-100,100)+random.NextDouble();
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine(" ");
        }

    }
}