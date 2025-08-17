using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.models
{
    public class Professor : Pessoa //Exemplo de herança onde a classe Professor herda atributos da classe Pessoa
    {
        public decimal Salario { get; set; }

        public void ApresentaSalario()
        {
            Console.WriteLine($"O salário informado é R$ {Salario}");
        }
    }
}