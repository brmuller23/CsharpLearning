﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)

        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            //conta.Numero = 86712540;
            //conta.Agencia = 867;

            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);


            ContaCorrente contadaGabriela = new ContaCorrente(867, 86712540);
           

            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);

            Console.ReadLine();
        }
    }
}
