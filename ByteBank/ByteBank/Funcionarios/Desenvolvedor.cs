using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        
        public Desenvolvedor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando Desenvolvedor");
        }

        public override void AumentarSalario()
        {
            Salario *= .15;
        }

        public override double GetBonificacao()
        {
            return Salario * .1;
        }
    }
}
