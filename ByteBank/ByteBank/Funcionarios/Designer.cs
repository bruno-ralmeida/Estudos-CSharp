using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando Designer");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * .17; //Chamando o método da classe mãe
        }
    }
}
