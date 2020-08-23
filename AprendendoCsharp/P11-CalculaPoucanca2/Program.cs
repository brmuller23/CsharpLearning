using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoucanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorinvestido = 1000;

            for(int contadormes = 1; contadormes <= 12; contadormes ++)
            {
                //valorinvestido = valorinvestido + valorinvestido * 0.0036;
                //valorinvestido = valorinvestido  * 1.0036;
                valorinvestido *= 1.0036;
                Console.WriteLine("Após " + contadormes + " meses, você terá R$" + valorinvestido);

            }



            Console.ReadLine();

        }
    }
}
