using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresenta() //habiblita a técnica do polimorfismo colocando o atributo virtual
        {
            Console.WriteLine($"\nOla meu nome é {Nome} tenho {Idade} anos.");
        }
    }
}