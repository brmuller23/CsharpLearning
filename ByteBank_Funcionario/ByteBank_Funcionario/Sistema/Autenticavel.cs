using ByteBank_Funcionario.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Funcionario.Sistema
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
       
    


