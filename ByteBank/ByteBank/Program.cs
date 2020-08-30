using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            Console.WriteLine("============================================");
            Console.WriteLine("=================    FIM    ================");
            Console.WriteLine("============================================");
            UsarSistema();
            Console.ReadKey();
        }
        public static void UsarSistema()
        {
            SistemaInterno si = new SistemaInterno();

            Diretor roberta = new Diretor("Roberta", "159.753.398-04", 5000);
            roberta.Senha = "123";
            si.Logar(roberta, "123");

            Console.WriteLine("=============================================");

            GerenteConta camila = new GerenteConta("Camila", "326.985.628-89", 2800);
            camila.Senha = "abc";
            si.Logar(camila, "ABC");

            Console.WriteLine("=============================================");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";
            si.Logar(parceiro, "123456");
            

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
