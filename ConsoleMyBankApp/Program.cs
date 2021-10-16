using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente("David de Oliveira", "000.000.000-00", "Analista");
                     

            ContaCorrente conta = new ContaCorrente(cliente, 01, 00001);

            
            Console.WriteLine("##### - Conta Corrente Ativada - #####");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta Corrente: {0}", conta.getConta());

            Console.WriteLine("Parabéns seu novo saldo é de R$ {0} Obrigado por criar a sua conta!", conta.getSaldo());

            //Efetuar deposito pelo Console
            double valorDeposito;

            Console.WriteLine("Qual valor de deposito?");
            valorDeposito = Convert.ToInt32(Console.ReadLine());
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu novo saldo é  {0}", conta.getSaldo());

            //Efetuar saque pelo console
            double valorSaque;

            Console.WriteLine("Qual valor de saque?");
            valorSaque = Convert.ToInt32(Console.ReadLine());
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo atual é  {0}", conta.getSaldo());

            //criar uma segunda pessoa
            Cliente clienteThais = new Cliente("Thais Ferreira Clemente", "444.444.444-44", "Analista de Vendas");
            //criar a conta da segunda pessoa
            ContaCorrente contaThais = new ContaCorrente(clienteThais, 01, 00002);

            //efetuar Pix para a segunda pessoa
            double valorPix;

            Console.WriteLine("Qual valor do Pix?");
            valorPix = Convert.ToInt32(Console.ReadLine());
            
            conta.Pix(valorPix, contaThais);

            Console.WriteLine("Seu saldo atual é ** R${0} **", conta.getSaldo());
            Console.WriteLine("Saldo da cliente {0} ** R${1} **", contaThais.getTitular().nome, contaThais.getSaldo());

            //cria uma conta poupança para nosso cliente
            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 00003);

            Console.WriteLine("### - Conta Poupança Criada - ###");
            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agencia: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());
        }
    }
}
