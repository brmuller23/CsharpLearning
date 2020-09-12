using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //classe      objeto            instancia - uma classe pode ter vários objetos     
            ContaCorrente contadaGabriela = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;

            ContaCorrente contadaGabrielaCosta = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;

            Console.WriteLine(contadaGabriela == contadaGabrielaCosta);

            contadaGabriela = contadaGabrielaCosta;
            Console.WriteLine(contadaGabriela == contadaGabrielaCosta);

            if(contadaGabriela.saldo >= 100) {

                contadaGabriela.saldo -= 100;

            }

            


            Console.ReadLine();
        }
    }
}
