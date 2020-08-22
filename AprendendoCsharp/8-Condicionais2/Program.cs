using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 8");

            int idadejoao = 18;
            //int quantidadepessoas = 2;

            //bool acompanhado = quantidadepessoas >= 2;
            bool acompanhado = true;
            


            if (idadejoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");

            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            Console.ReadLine();







            Console.ReadLine();

        }
    }
}
