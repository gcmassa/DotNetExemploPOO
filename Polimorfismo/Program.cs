// See https://aka.ms/new-console-template for more information

using Polimorfismo.models;

Aluno a1 = new Aluno();

a1.Nome = "Joazinho";
a1.Idade = 20;
a1.Nota = 9.5;
a1.Apresenta();
a1.ApresentaNota();

Professor p1 = new Professor();

p1.Nome = "Giancarlo";
p1.Idade = 44;
p1.ValorSalario = 3500;
p1.Apresenta();
p1.ApresentaSalario();
