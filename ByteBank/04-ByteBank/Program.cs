using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoBruno = new ContaCorrente();

            contadoBruno.titular = "Jose";

            Console.WriteLine(contadoBruno.saldo);

            bool resultadoSaque = contadoBruno.Sacar(500);

            Console.WriteLine(contadoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contadoBruno.Depositar(500);
            Console.WriteLine(contadoBruno.saldo);

            ContaCorrente contadaGabriela = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";

            contadoBruno.Transferir(200, contadaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contadaGabriela.saldo);

            contadaGabriela.Transferir(100, contadoBruno);
            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contadaGabriela.saldo);

            Console.ReadLine();

        }

    }
}
