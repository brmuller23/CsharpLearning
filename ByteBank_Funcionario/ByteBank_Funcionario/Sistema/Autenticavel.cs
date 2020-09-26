using ByteBank_Funcionario.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Funcionario.Sistema
{
    public abstract class Autenticavel : Funcionario

    {
        public string Senha { get; set; }

        public Autenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }

}
