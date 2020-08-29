using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadKey();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Desenvolvedor bruno = new Desenvolvedor("Bruno", "489.799.530-20", 2200);

            Designer ana = new Designer("ana", "833.222.048-39", 3000);
          
            Diretor roberta = new Diretor("Roberta", "159.753.398-04", 5000);
            
            Auxiliar igor = new Auxiliar("Igor", "981.198.778-53", 2500);

            GerenteConta camila = new GerenteConta("Camila", "326.985.628-89", 2800);

            gerenciadorBonificacao.Registrar(bruno);
            gerenciadorBonificacao.Registrar(ana);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
               gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
