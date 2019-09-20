using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();

            c1.titular = "Bruno Rocha";
            c1.agencia = 999;
            c1.conta = 12345;
            c1.saldo = 100.00;

            Console.WriteLine(c1.apresentacao());
            Console.ReadLine();
        }
    }
}
