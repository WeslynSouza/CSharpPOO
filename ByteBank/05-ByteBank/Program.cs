using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "123.456.789.00";
            //gabriela.profissao = "Arquiteta";

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = new Cliente();
            contaGabriela.titular.nome = "Gabriela";
            contaGabriela.titular.cpf = "123.456.789.00";
            contaGabriela.titular.profissao = "Arquiteta";

            Console.WriteLine("Titular da conta: " + contaGabriela.titular.nome);

            Console.ReadLine();
        }
    }
}
