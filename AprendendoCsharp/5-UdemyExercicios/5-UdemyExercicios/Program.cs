using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_UdemyExercicios
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Insira a primeira nota: ");
              string nota1 = Console.ReadLine();
              double.Parse(nota1);
            Console.Write("Insira a segunda nota: ");
              string nota2 = Console.ReadLine();
              double.Parse(nota2);

            double resultado = (double.Parse(nota1) + double.Parse(nota2)) / 2;

            Console.WriteLine("A média entre " + nota1 + " e " + nota2 + " é " + resultado);

            Console.ReadLine();
        }
    }
}
