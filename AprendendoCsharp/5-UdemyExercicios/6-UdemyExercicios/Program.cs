using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_UdemyExercicios
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Digite um numero: ");
            string n1 = Console.ReadLine();
            int.Parse(n1);

            int abaixo = int.Parse(n1) - 1;
            Console.WriteLine("O antecessor de " + int.Parse(n1) + " é " + abaixo);

            int acima = int.Parse(n1) + 1;
            Console.WriteLine("O sucessor de " + int.Parse(n1) + " é " + acima);

            Console.ReadLine();
        }
    }
}
