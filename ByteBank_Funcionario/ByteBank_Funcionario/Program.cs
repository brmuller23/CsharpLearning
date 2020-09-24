using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_Funcionario.Funcionarios;

namespace ByteBank_Funcionario
{
    class Program
    {
        static void Main(string[] args)

        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.nome = "Carlos";
            carlos.CPF = "047.159.759-77";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor();
            roberta.nome = "Roberta";
            roberta.CPF = "047.159.700-77";
            roberta.Salario = 5000;

         

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();



        }

    }
}
