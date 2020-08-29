using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        
        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando Auxiliar");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return Salario * .20; //Chamando o método da classe mãe
        }
    }
}
