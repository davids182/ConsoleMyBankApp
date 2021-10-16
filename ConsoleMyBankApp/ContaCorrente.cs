using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    class ContaCorrente : Conta
    {

        public Cliente titular;  // o titular é um cliente então deve ser do tipo Cliente
      


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
        

       
        // valida valor e efetua transação PIX para outra conta
        public double Pix(double valor, ContaCorrente contaTerceiro)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("#### - Saldo insuficiente!! - ####");

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
