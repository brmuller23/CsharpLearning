using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_UdemyExercicios
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Informe o nome do Funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o salário: ");
            string salario = Console.ReadLine();
            double.Parse(salario);

            Console.WriteLine("O funcionário é: " + nome);
            Console.WriteLine("O seu salário é: " + salario);

            Console.ReadLine();


        }
    }
}
