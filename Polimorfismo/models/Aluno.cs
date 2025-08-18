using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresenta() //ao criar o método com o atributo override possibilita chamar o método polimorfo e sobre-escreve
        {
            //base.Apresenta();
            Console.WriteLine($"\nOlá! Meu nome é {Nome}, tenho {Idade} anos de idade e sou aluno!");
        }

        public void ApresentaNota()
        {
            //Console.WriteLine("Sou aluno!");
            Console.WriteLine($"A nota informa é {Nota}");
        }
    }
}