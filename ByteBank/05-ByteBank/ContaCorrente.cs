
namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular = null;
        public int agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contadestino)
        {
            if(this.saldo < valor)
                return false;
 

            this.saldo -= valor;
            contadestino.Depositar(valor);
            return true;

        }
    }

}