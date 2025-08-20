// See https://aka.ms/new-console-template for more information

using Heranca.models;

Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1 - Aluno");
Console.WriteLine("2 - Professor");
Console.WriteLine("3 - Sair");
Console.WriteLine("\nDigite uma opção:");
int opcao = int.Parse(Console.ReadLine()); //aguarada informação para qual opção iniciar

switch (opcao)
{
    case 1:
        Aluno a1 = new Aluno();
        Console.WriteLine("Digite o nome ");
        a1.Nome = Console.ReadLine();
        Console.WriteLine("Digite a Idade:");
        a1.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite uma nota (0 a 10):");
        a1.Nota = int.Parse(Console.ReadLine());
        a1.Apresentar();
        a1.RepresentaNota();
        break;
    case 2:
        Professor p1 = new Professor();
        Console.WriteLine("Digite o nome:");
        p1.Nome = Console.ReadLine();
        Console.WriteLine("Informe sua Idade:");
        p1.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o salário:");
        p1.Salario = decimal.Parse(Console.ReadLine());
        p1.Apresentar();
        p1.ApresentaSalario();
        break;
    case 3:
        Console.WriteLine("Sistema encerrado!");
        break;
}
