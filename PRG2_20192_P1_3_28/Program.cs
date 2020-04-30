using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_3_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.Clear();
		
		    Console.WriteLine("PROGRAM MENULIS LAGU ANAK AYAM");
		    Console.WriteLine("-------------------------------");
            Console.Write("N : ");
            int N = Convert.ToInt16(Console.ReadLine());

            do
            {
                i = N - 1;
                if (N > 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", N,i);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", N);
                }

                N--;
            } while (N != 0);
        }
    }
}
