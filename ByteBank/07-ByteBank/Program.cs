using System;


namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente(1234, 4555);

            Console.WriteLine($"Contas Criadas: {ContaCorrente.TotalContasCriadas}");

            
            Console.ReadKey();
        }
    }
}
