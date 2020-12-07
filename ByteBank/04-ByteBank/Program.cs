using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titulo = "Bruno";
            conta.saldo = 200;

            Console.WriteLine("Saldo atual: " + conta.saldo);

            conta.Sacar(50);

            Console.WriteLine("Saldo atual depois do saque: " + conta.saldo);


            conta.Depositar(300);

            Console.WriteLine("Saldo atual depois do deposito: " + conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titulo = "Gabriela";
            conta2.saldo = 50;

            Console.WriteLine("O saldo da conta da " + conta2.titulo + " é: " + conta2.saldo);

            conta.Transferir(100, conta2);

            Console.WriteLine("O saldo da conta da " + conta2.titulo + " apos a transferencia é: " + conta2.saldo);
            Console.WriteLine("O saldo da conta do " + conta.titulo + " agora é: " + conta.saldo);

            Console.ReadLine();

        }
    }
}
