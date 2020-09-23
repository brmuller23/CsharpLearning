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

            Funcionario carlos = new Funcionario(1);
            carlos.nome = "Carlos";
            carlos.CPF = "047.159.759-77";
            carlos.Salario = 2000;
                
           
        }
    }
}
