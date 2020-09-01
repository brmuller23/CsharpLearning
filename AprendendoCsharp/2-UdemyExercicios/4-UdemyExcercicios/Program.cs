using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_UdemyExcercicios
{
    class Program
    {
        static void Main(string[] args)

        { 
            int soma;
            
            Console.Write("Informe o primeiro numero: ");
               string n1 = Console.ReadLine();
               int.Parse(n1);
            Console.Write("Informe o segundo numero: ");
               string n2 = Console.ReadLine();
               int.Parse(n2);
               soma = int.Parse(n1) + int.Parse(n2);

            Console.Write("A soma de " + n1 + " + " + n2 + " é igual a " + soma);

            Console.ReadLine();
        }
    }
}
