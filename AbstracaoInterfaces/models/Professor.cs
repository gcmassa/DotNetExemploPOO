using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoInterfaces.models
{
    public class Professor : Pessoa
    //public sealed class Professor : Pessoa //declara com sealed informando que esta classe se encontra selada e não poder ser mais herdada
    {
        public Professor()
        {

        }
        public Professor(string nome) : base(nome)
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        //public sealed override void Apresentar() //declara com sealed informando que este método é selado e pode ser herdado para classes filhas
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}, sou professor! Tenho {Idade} anos e ganho R$ {Salario}!");
        }
    }
}