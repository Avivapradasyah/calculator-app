using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi kalkulator";

            int a, b, menu;

            Console.WriteLine("=============================================");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine("PILIHAN MENU KALKULATOR \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian \n");
            Console.Write("Inputkan Nomor Menu Yang Di Inginkan [1..4] : ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Write("inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("hasil penambahan " + a + " +" + b + " = " + penambahan(a, b));
                    break;
                case 2:
                    Console.Write("inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                    break;
                case 3:
                    Console.Write("inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                    break;
                case 4:
                    Console.Write("inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, Menu Yang Anda Inginkan Tidak Tersedia");
                    break;
            }

            Console.WriteLine("\nTekan Random Untuk Keluar Dari Program");
            Console.WriteLine();
            Console.WriteLine("=============== TERIMA KASIH :) =============");
            Console.WriteLine("=============================================");
            Console.ReadKey();
           
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }

    }
}