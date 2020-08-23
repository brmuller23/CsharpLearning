using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for(int contadorano = 1; contadorano <= 5; contadorano++)
            {

                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {

                    valorInvestido *= fatorRendimento;

                }
                fatorRendimento += 0.0010;



            }
            //Console.WriteLine("Tempo de investimento foi de " );
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);
            
            
            Console.ReadLine();


        }
    }
}
