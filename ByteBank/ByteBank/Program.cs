using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Nome = "Carlos";
            f1.CPF = "123.456.980-80";
            f1.Salario = 5000.00;


            Diretor f2 = new Diretor();
            f2.Nome = "Ana";
            f2.CPF = "143.756.980-80";
            f2.Salario = 15000.00;

            Console.WriteLine(f1.ToString());
            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine(f2.ToString());

            

            Console.ReadLine();
        }
    }
}
