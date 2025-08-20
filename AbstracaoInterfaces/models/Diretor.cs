using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoInterfaces.models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}, sou Diretor! Tenho {Idade} anos e ganho R$ {Salario}!");
        }    
    }
}