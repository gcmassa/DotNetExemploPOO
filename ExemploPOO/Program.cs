// See https://aka.ms/new-console-template for more information

using ExemploPOO.models;

Pessoa p1 = new Pessoa();

p1.Nome = "Giancarlo";
p1.Idade = 44;

p1.Apresentar(); //istancia a funcao Apresentar()

Console.WriteLine("\n");

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo(); //encapsulamento usando uma funcao da classe que tem acesso a um atributo private
c1.Sacar(500);
c1.ExibirSaldo();
