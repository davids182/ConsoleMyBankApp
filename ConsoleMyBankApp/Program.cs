using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente("David de Oliveira", "000.000.000-00", "Analista");
                     

            ContaCorrente conta = new ContaCorrente();

            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 00001;

            Console.WriteLine("##### - Conta Corrente Ativada - #####");
            Console.WriteLine("Titular: {0}", conta.titular.nome);
            Console.WriteLine("Agência: {0}", conta.agencia);
            Console.WriteLine("Conta Corrente: {0}", conta.conta);


        }
    }
}
