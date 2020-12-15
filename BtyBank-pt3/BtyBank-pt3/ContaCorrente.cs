
namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value > 0)
                    _saldo = value;
                else
                    return;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contadestino)
        {
            if(_saldo < valor)
                return false;
 

            _saldo -= valor;
            contadestino.Depositar(valor);
            return true;

        }
    }

}