using System;
using System.Globalization;

namespace _2_UdemyEntradaDeDadosExercicios
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Entre seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("quantos quartos tem na sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
            Console.WriteLine("entre seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            ;
        }
    }
}
