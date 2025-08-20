using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Pessoa
    {
        //Cria a classe tipo Pessoa representando o que seja pro sistea usando uma abstração
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá nome é {Nome} e tenho {Idade} anos");
        }
    }
}