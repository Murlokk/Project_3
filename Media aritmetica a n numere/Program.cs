using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_aritmetica_a_n_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumarulIntrodus;
            int n, Numarator = 1;
            float MediaAritmetica, Suma = 0;
            Console.WriteLine("Introduce numarul de numere pe care doriti sa aflati media aritmetica :");
            n = Convert.ToInt32(Console.ReadLine());
            while (Numarator <= n)
            {
                Console.WriteLine("Inroduceti numarul :" + Numarator + "");
                NumarulIntrodus = Convert.ToInt32(Console.ReadLine());
                Suma += NumarulIntrodus;
                ++Numarator;
            }
            MediaAritmetica = (float)Suma / (n);
            Console.WriteLine("\nMedia aritmetica este");
            Console.Write(MediaAritmetica);
        }
    }
}
