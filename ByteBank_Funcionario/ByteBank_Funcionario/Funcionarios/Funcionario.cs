using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Funcionario.Funcionarios
{
   public abstract class Funcionario

    {
        public static int TotaldeFucnionatirios { get; private set; }

        public string nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario");
            CPF = cpf;
            Salario = salario;
            TotaldeFucnionatirios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
     
    }
}
