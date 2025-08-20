using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoInterfaces.models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome) //chama o construtor, herdando a regra da classe Pai
        {

        }
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá. meu nome é {Nome}, tenho {Idade} anos, sou aluno e minha nota é {Nota}.");
        }
    }
}