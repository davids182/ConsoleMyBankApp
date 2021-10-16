using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    class ContaPoupanca : Conta // herda a classe abstrata conta
    {

        public ContaPoupanca(Cliente titular, int agencia, int conta)
        {

            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);

        }

    }
}
