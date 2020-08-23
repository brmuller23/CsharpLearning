using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero <= 100)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " o numero é par");
                    numero++;
                }
                else
                {
                    Console.WriteLine(numero + " o numero é par");
                    numero++;
                }
            }
            Console.ReadLine();
        }
    }
}