using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoInterfaces.models
{
    public class Pessoa
    {
        public Pessoa()// aplica alternativa do construtor onde o atributo nome pode não ser campo obrigatório
        {
            
        }
        public Pessoa(string nome)// Define que o atributo nome é obrigatório
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}