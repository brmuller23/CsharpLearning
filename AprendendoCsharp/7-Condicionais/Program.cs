using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadejoao = 16;
            int quantidadepessoas = 2;

            if (idadejoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");

            }

            else
            {
                if (quantidadepessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas esta acompanhado.");
                }
                else
                {
                    Console.WriteLine("João nao possui mais de 18 anos, não pode entrar");
                }

            }

            Console.ReadLine();



        }
    }
}
