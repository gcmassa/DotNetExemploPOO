using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoInterfaces.models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor) //obrigatoriamente ao herdar de Conta tem que implementar o metodo Creditar
        {
            //throw new NotImplementedException();
            saldo += valor;
        }
    }
}