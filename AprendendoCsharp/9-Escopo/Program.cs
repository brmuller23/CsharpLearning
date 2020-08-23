using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Excutando o projeto 9"); 

            int idadejoao = 18;
            bool acompanhado = false;
            string mensagemadicional;

            if (acompanhado == true)
            {
                mensagemadicional = "João esta acompanhado!";
                Console.WriteLine(mensagemadicional);
            }
            else

                mensagemadicional = "João não esta acompanhado.";


            if (idadejoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagemadicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            Console.ReadLine();


        }
    }
}

