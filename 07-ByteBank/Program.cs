using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente(1234, 4555);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
