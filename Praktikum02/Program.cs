using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator Aplication";

            int statement = Statement();
            if (statement < 1 || statement > 5)
            {
                Console.WriteLine();
                Console.WriteLine("Return");
                HomePage();
            }

            Console.WriteLine();
            Console.Write("Masukkan nilai a: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (statement == 1)
                Console.WriteLine($"Hasil Penjumlahan {x} + {y} = {Penjumlahan(x, y)}");

            else if (statement == 2)
                Console.WriteLine($"Hasil Pengurangan {x} - {y} = {Pengurangan(x, y)}");

            else if (statement == 3)
                Console.WriteLine($"Hasil Perkalian {x} * {y} = {Perkalian(x, y)}");

            else
                Console.WriteLine($"Hasil Pembagian {x} / {y} = {Pembagian(x, y)}");

            HomePage();
        }

        static int Statement()
        {
            Console.WriteLine("Main Menu");

            Console.WriteLine();
            Console.WriteLine("1. Penjumlahan Bilangan");
            Console.WriteLine("2. Pengurangan Bilangan");
            Console.WriteLine("3. Perkalian Bilangan");
            Console.WriteLine("4. Pembagian Bilangan");

            Console.WriteLine();
            Console.Write("Input data: ");

            return int.Parse(Console.ReadLine());
        }

        static int Penjumlahan(int x, int y)
        {
            return x + y;
        }
        static int Pengurangan(int x, int y)
        {
            return x - y;
        }

        static int Perkalian(int x, int y)
        {
            return x * y;
        }
        static double Pembagian(int x, int y)
        {
            return (double) x / y;
        }

        static void HomePage()
        {
            Console.WriteLine();
            Console.WriteLine("Return");
            Console.ReadKey();

            Environment.Exit(0);
        }

    }
}