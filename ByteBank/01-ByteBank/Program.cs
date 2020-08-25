using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadaGrabriela = new ContaCorrente();

            contadaGrabriela.titular = "Gabriela";
            contadaGrabriela.agencia = 863;
            contadaGrabriela.numero = 863452;
            contadaGrabriela.saldo = 100;

            Console.WriteLine(contadaGrabriela.titular);
            Console.WriteLine(contadaGrabriela.agencia);
            Console.WriteLine(contadaGrabriela.numero);
            Console.WriteLine(contadaGrabriela.saldo);


            Console.ReadLine();


        }
    }
}
