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
            ContaCorrente conta = new ContaCorrente(867, 867239);
            ContaCorrente conta2 = new ContaCorrente(867, 867239);
            ContaCorrente conta3 = new ContaCorrente(867, 867239);

            Console.WriteLine(ContaCorrente.TotalDeContas);

            Console.ReadLine();
        }
    }
}
