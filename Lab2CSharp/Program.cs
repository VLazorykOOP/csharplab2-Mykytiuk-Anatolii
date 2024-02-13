using System;

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

        // Метод для знаходження номеру останнього максимального елемента в масиві



        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
            Console.WriteLine("Lab 1 !");

            Console.WriteLine("Please input task");

            Console.Write("n=");

            byte n = byte.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("You choise task 1"); Task1(); break;
                case 2: Console.WriteLine("You choise task 2"); Task2(); break;
                case 3: Console.WriteLine("You choise task 3"); ; break;
                case 4: Console.WriteLine("You choise task 4"); ; break;

            }

        }
    }
}

