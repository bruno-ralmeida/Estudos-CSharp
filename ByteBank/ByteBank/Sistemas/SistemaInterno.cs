using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
       public bool Logar(IAutenticador usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);


            if (usuarioAutenticado)
            {
                Console.WriteLine($"Seja bem-vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
