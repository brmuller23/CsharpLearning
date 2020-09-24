using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Funcionario.Funcionarios
{
   public class Funcionario

    {

        public string nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public virtual double GetBonificacao()
        {
          
            return Salario * 0.10;

        }
    }
}
