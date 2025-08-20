// See https://aka.ms/new-console-template for more information

using AbstracaoInterfaces.models;

Corrente c = new Corrente();

c.Creditar(500);
c.ExibirSaldo();

Professor p1 = new Professor("Giancarlo");
Aluno a1 = new Aluno("Eduardo");

a1.Apresentar();
p1.Apresentar();

Computador c1 = new Computador(); //Conceito de herança da classe System.Object
Console.WriteLine(c1.ToString());

