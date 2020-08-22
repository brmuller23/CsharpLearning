using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaractereETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Executando o projeto 5 - Caracteres e textos");

            // character
            char primeiraletra = 'a';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)65;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string titulo =  "Alura Cursos de tecnoloia";
            string cursosProgamacao = 
@" - .NET 
   - Java 
   - Javascript";

            Console.WriteLine(cursosProgamacao);
            Console.WriteLine(titulo);



            Console.ReadLine();
        }

    }
}
