using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class ContaCorrente
    {
        //método que utiliza de encapsulamento
        public ContaCorrente(int numeroConta, decimal saldoInicial) //define um construtor
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo; // atributo privado onde somente a classe tem acesso

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado e maior que o saldo disponivel");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel e: " + saldo);
        }
    }
}