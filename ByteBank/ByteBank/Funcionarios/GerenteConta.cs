using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteConta : Funcionario
    {
        
        public GerenteConta(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * .25; //Chamando o método da classe mãe
        }
    }
}
