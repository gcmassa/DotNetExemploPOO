
---

# 📄 Documento Explicativo: Polimorfismo em C#

## 🧠 Visão Geral

Este projeto demonstra o conceito de **polimorfismo** em C# por meio de uma estrutura simples com três classes principais: `Pessoa`, `Aluno` e `Professor`. A classe `Pessoa` serve como base, enquanto `Aluno` e `Professor` herdam dela e sobrescrevem seu comportamento. O `Program.cs` (embora esteja duplicando a classe `Pessoa`, como veremos) seria o ponto de entrada para instanciar e testar essas classes.

---

## 🧱 Estrutura das Classes

### 1. `Pessoa.cs`

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void Apresenta()
    {
        Console.WriteLine($"\nOla meu nome é {Nome} tenho {Idade} anos.");
    }
}
```

- **Propósito**: Classe base que representa uma pessoa genérica.
- **Polimorfismo**: O método `Apresenta()` é marcado como `virtual`, permitindo que classes derivadas o sobrescrevam.
- **Comentário contextual**: Explica que o uso de `virtual` habilita o polimorfismo.

---

### 2. `Aluno.cs`

```csharp
public class Aluno : Pessoa
{
    public double Nota { get; set; }

    public override void Apresenta()
    {
        Console.WriteLine($"\nOlá! Meu nome é {Nome}, tenho {Idade} anos de idade e sou aluno!");
    }

    public void ApresentaNota()
    {
        Console.WriteLine($"A nota informa é {Nota}");
    }
}
```

- **Herança**: `Aluno` herda de `Pessoa`.
- **Polimorfismo**: O método `Apresenta()` é sobrescrito com `override`, alterando o comportamento original.
- **Comentário contextual**: Explica que `override` permite a substituição do método da classe base.
- **Método adicional**: `ApresentaNota()` mostra a nota do aluno.

---

### 3. `Professor.cs`

```csharp
public class Professor : Pessoa
{
    public decimal ValorSalario { get; set; }

    public override void Apresenta()
    {
        Console.WriteLine($"\nMeu nome é {Nome}, tenho {Idade} anos e sou um Professor");
    }

    public void ApresentaSalario()
    {
        Console.WriteLine($"O salario informado é R$ {ValorSalario}");
    }
}
```

- **Herança**: `Professor` também herda de `Pessoa`.
- **Polimorfismo**: O método `Apresenta()` é sobrescrito para refletir a identidade de um professor.
- **Comentário contextual**: Reforça o uso de `override` para redefinir o comportamento.
- **Método adicional**: `ApresentaSalario()` exibe o salário.

---

## ⚙️ Program.cs — Observações Importantes

```csharp
namespace Polimorfismo.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresenta()
        {
            Console.WriteLine($"\nOla meu nome é {Nome} tenho {Idade} anos.");
        }
    }
}
```

- **Problema**: O `Program.cs` está redefinindo a classe `Pessoa`, o que pode causar conflitos se o projeto já tiver `Pessoa.cs`.
- **Sugestão**: O `Program.cs` deveria conter o método `Main()` para instanciar objetos de `Aluno` e `Professor`, e demonstrar o polimorfismo em ação.

Exemplo ideal de `Main()`:

```csharp
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Aluno { Nome = "Carlos", Idade = 20, Nota = 8.5 };
        Pessoa pessoa2 = new Professor { Nome = "Ana", Idade = 40, ValorSalario = 3500 };

        pessoa1.Apresenta(); // Chama Apresenta() de Aluno
        pessoa2.Apresenta(); // Chama Apresenta() de Professor

        // Para acessar métodos específicos:
        ((Aluno)pessoa1).ApresentaNota();
        ((Professor)pessoa2).ApresentaSalario();
    }
}
```

---

## 🧩 Conceitos Demonstrados

| Conceito        | Aplicação no Código |
|----------------|---------------------|
| Herança        | `Aluno` e `Professor` herdam de `Pessoa` |
| Polimorfismo   | `Apresenta()` é sobrescrito nas classes derivadas |
| Encapsulamento | Uso de propriedades (`Nome`, `Idade`, etc.) |
| Comentários    | Explicam o uso de `virtual` e `override` para polimorfismo |

---

## ✅ Conclusão

Este projeto é uma ótima introdução ao polimorfismo em C#. Os comentários ajudam a entender como o `virtual` e `override` funcionam, e como o comportamento de métodos pode ser alterado em subclasses. Com uma pequena correção no `Program.cs`, o exemplo pode ser executado para mostrar o poder da orientação a objetos.
