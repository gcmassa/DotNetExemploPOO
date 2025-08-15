// See https://aka.ms/new-console-template for more information

using DotNetExemploPOO.models;

Pessoa p1 = new Pessoa(); // Objeto da classe Pessoa

p1.Nome = "Giancarlo";
p1.Idade = 44;

p1.Apresentar(); //excuta a ação

Console.WriteLine("\n");

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();//encapsulmento usando uma funcao da classe que tem acesso a um atributo private
c1.Sacar(5000);
c1.ExibirSaldo();