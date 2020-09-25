using System;
using System.Collections.Generic;
using System.Globalization;
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
            CalcularBonificacao();

            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("835.472.872-01");
            pedro.nome = "Pedro";

            Diretor roberta = new Diretor("835.472.852-01");
            roberta.nome = "Roberta";

            Auxiliar maria = new Auxiliar("835.478.872-01");
            maria.nome = "Maria";

            GerentedeConta camila = new GerentedeConta("835.472.872-77");
            camila.nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(maria);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("total de bonfificacao do mes" + 
             gerenciadorBonificacao.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
