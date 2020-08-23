using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calculando Poupança");

            double valorinvestido = 1000;
            int contadormes = 1;

            while (contadormes <= 12)
            {

                valorinvestido = valorinvestido + valorinvestido * 0.0036;
                Console.WriteLine("Após " + contadormes + " meses, você terá R$" + valorinvestido);

                //contadormes = contadormes + 1;
                //contadormes += 1;
                contadormes++; 
            }


            // 0.36% = 0.0036
            //valorinvestido = valorinvestido + valorinvestido * 0.0036;
            //Console.WriteLine("Após 2 mês, você terá R$" + valorinvestido);



            Console.ReadLine();
        }
    }
}
