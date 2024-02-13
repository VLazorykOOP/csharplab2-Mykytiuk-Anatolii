using System;

namespace Lab2CSharp
{
    internal class Program
    {

        static void task1()
        {
            Console.WriteLine("You choise task 1:");
            Console.WriteLine("Input size of array 1");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Input ellemnts of array 1:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
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

            Console.WriteLine("Розмірність масиву ");
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
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
            Console.WriteLine("Lab 1 !");

            Console.WriteLine("Please input task");

            Console.Write("n=");

            byte n = byte.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("You choise task 1"); task1(); break;
                case 2: Console.WriteLine("You choise task 2"); ; break;
                case 3: Console.WriteLine("You choise task 3"); ; break;
                case 4: Console.WriteLine("You choise task 4"); ; break;

            }

        }
    }
}
