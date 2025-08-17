using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.models
{
    public class Aluno : Pessoa //exemplo de henrança onde a classe Aluno herda atributos da classe Pessoa
    {
        public double Nota { get; set; }

        public void RepresentaNota()
        {
            if (Nota >= 0 && Nota <= 10) //verifica se a nota informada é válida
            {
                Console.WriteLine($"A nota informada é {Nota} ");
            }
            else
            {
                Console.WriteLine($"A nota <{Nota}> informada é inválida");
            }
        }
    }
    
}