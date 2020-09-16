using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)

        {
           // Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "454.484.214-11";

            ContaCorrente conta = new ContaCorrente()
;
            //conta.titular = gabriela;

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "454.484.214-11";
            conta.titular.profissao = "Desenvolvedora C#";

            //a referencia é nula

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

        }
    }
}
