using ByteBank_Funcionario.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Funcionario.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel Funcionario, string senha)
        {
            bool usuarioAutenticado = Funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }

        public bool Logar(GerentedeConta Funcionario, string senha)
        {
            bool usuarioAutenticado = Funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }
    }
}

