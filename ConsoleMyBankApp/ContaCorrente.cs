﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    public class ContaCorrente : Conta  // Conta Corrente herda as classes e métodos da classe abstrata Conta
    {



        public ContaCorrente(Cliente titular, int agencia, int conta)
        {

            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);

        }  
      
    }
}
