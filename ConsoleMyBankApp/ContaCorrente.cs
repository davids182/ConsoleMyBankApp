using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    class ContaCorrente
    {

        public Cliente titular;  // o titular é um cliente então deve ser do tipo Cliente
        public int agencia;
        public int conta;

        private double saldo = 100.00;


        public ContaCorrente(Cliente titular, int agencia, int conta)
        {

            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);

        }

        public Cliente getTitular()
        {

            return this.titular;

        }

        public void setTitular(Cliente titular)
        {

            this.titular = titular;

        }
        public int getAgencia()
        {

            return this.agencia;

        }

        public void setAgencia(int agencia)
        {

            this.agencia = agencia;

        }
        public int getConta()
        {

            return this.conta;

        }

        public void setConta(int conta)
        {

            this.conta = conta;

        }

        public double getSaldo()
        {

            return this.saldo;

        }

        //valida valor do deposito e efetua transação 
        public double Depositar( double valor)
        {

            if (valor <= 0)
            {
                return 0;
            }
            else
            {
                this.saldo += valor;
            }

            return this.saldo;
        }

        //valida valor e efetua transação de saque e debita valor fixo da taxa
        public double Sacar(double valor)
        {
            double taxasaque = 0.50;

            if (valor > this.saldo)
            {
                Console.WriteLine("#### - Saldo insuficiente!! - ####");
               
            }
            if (valor < 2) {
                Console.WriteLine("### - Saque mínimo R2,00!! - ####");
               
            }
            else
            {
                this.saldo -= valor;
                this.saldo -= taxasaque;
                Console.WriteLine("Taxa de saque R$ {0}. Saldo atual R${1}", taxasaque, this.saldo);
            }
            return this.saldo;

        }
        // valida valor e efetua transação PIX para outra conta
        public double Pix(double valor, ContaCorrente contaTerceiro)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("#### - Saldo insufic000iente!! - ####");

            }
            else
            {
                this.saldo -= valor;
                contaTerceiro.Depositar(valor);
                Console.WriteLine("Pix realizado! novo valor **R$ {0}**", valor);
            }
            return this.saldo;

        }




    }
}
