using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
       
        public override double GetBonification()
        {
            return Salario;
        }

   
    }
}
