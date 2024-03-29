﻿using System;

namespace Lab2CSharp
{
    internal class Program
    {

        static void Task1()
        {
            Console.WriteLine("You choise task 1:");
            Console.WriteLine("Enter the length of the array 1");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Input ellemnts of array 1:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count1 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count1++;
                }
            }

            Console.WriteLine(count1);

            Console.WriteLine("Enter the length of the array 2 ");
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[n, m];
            int count2 = 0;

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            for (int i = 0; i < b.GetLength(0); ++i)
                for (int j = 0; j < b.GetLength(1); ++j)
                    if (b[i, j] % 2 != 0) count2++;

            Console.WriteLine(count2);

        }

        //---------------------------------------------------------------//

        static void Task2()
        {
            Console.WriteLine("Enter the length of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            // Введення елементів масиву
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Знаходження номеру останнього максимального елемента
            int lastIndex = 0;
            int maxElement = a[0];

            // Перебираємо всі елементи масиву
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] >= maxElement)
                {
                    maxElement = a[i];
                    lastIndex = i;
                }
            }

            if (lastIndex != -1)
            {
                Console.WriteLine($"The index of the last maximum element is: {lastIndex}");
            }
            else
            {
                Console.WriteLine("Array is empty!");
            }
        }

        static void Task3()
        {
            Console.WriteLine("Enter the size of the square matrix (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            // Введення елементів матриці
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrix[{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Поміняти місцями стовпці відповідно до умови
            int middleColumn = n / 2;
            if (n % 2 == 0) // Кількість стовпців парна
            {
                SwapColumns(matrix, middleColumn - 1, middleColumn);
            }
            else // Кількість стовпців непарна
            {
                SwapColumns(matrix, 0, middleColumn);
            }

            // Виведення результату
            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void SwapColumns(int[,] matrix, int col1, int col2)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;
            }
        }

static int[][] Input()
        {
            Console.WriteLine("Enter the length of the array:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Enter the length of row {i + 1}:");
                Console.Write($"Length of row {i + 1} = ");
                int rowLength = int.Parse(Console.ReadLine());
                a[i] = new int[rowLength];
                for (int j = 0; j < rowLength; ++j)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0,5} ", a[i]);
        }

        static void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }

        static int Pare(int[] a)
        {
            int pare = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] % 2 == 0) { pare = a[i]; }
            return pare;
        }

        static void Task4()
        {
            int[][] myArray = Input();
            Console.WriteLine("Original array:");
            Print2(myArray);
            int[] result = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; ++i)
                result[i] = Pare(myArray[i]);
            Console.WriteLine("New array:");
            Print1(result);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
            Console.WriteLine("Lab 1 !");

            Console.WriteLine("Please input task");

            Console.Write("n=");

            byte n = Convert.ToByte(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("You choise task 1"); Task1(); break;
                case 2: Console.WriteLine("You choise task 2"); Task2(); break;
                case 3: Console.WriteLine("You choise task 3"); Task3(); break;
                case 4: Console.WriteLine("You choise task 4"); Task4(); break;

            }

        }
    }
}

