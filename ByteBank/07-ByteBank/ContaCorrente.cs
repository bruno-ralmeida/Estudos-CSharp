// using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalContasCriadas { get; private set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }

       
        
        private double _saldo = 100;

        public ContaCorrente (int ag, int conta)
        {
            this.Agencia = ag;
            this.Numero = conta;
            ContaCorrente.TotalContasCriadas++;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
