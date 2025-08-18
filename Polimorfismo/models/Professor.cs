using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.models
{
    public class Professor : Pessoa
    {
        public decimal ValorSalario { get; set; }

        public override void Apresenta()
        {
            //base.Apresenta();
            Console.WriteLine($"\nMeu nome é {Nome}, tenho {Idade} anos e sou um Professor");
        }

        public void ApresentaSalario()
        {
            //Console.WriteLine("Sou Professor!");
            Console.WriteLine($"O salario informado é R$ {ValorSalario}");
        }
    }
}