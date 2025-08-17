
---

## 📦 Visão Geral do Projeto

Este projeto demonstra o conceito de herança em programação orientada a objetos usando C#. Ele define uma classe base `Pessoa` e duas classes derivadas: `Aluno` e `Professor`. O programa principal (`Program.cs`) permite ao usuário interagir com essas classes via console, simulando um pequeno sistema de cadastro e exibição de informações.

---

## 🧩 Estrutura das Classes

### 👤 Classe `Pessoa`

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome} e Idade {Idade}");
    }
}
```

**Descrição:**
- Classe base que representa uma pessoa genérica.
- Contém duas propriedades: `Nome` e `Idade`.
- O método `Apresentar()` exibe essas informações no console.

---

### 🎓 Classe `Aluno`

```csharp
public class Aluno : Pessoa
{
    public double Nota { get; set; }

    public void RepresentaNota()
    {
        if (Nota >= 0 && Nota <= 10)
        {
            Console.WriteLine($"A nota informada é {Nota} ");
        }
        else
        {
            Console.WriteLine($"A nota <{Nota}> informada é inválida");
        }
    }
}
```

**Descrição:**
- Herda de `Pessoa`, portanto possui `Nome` e `Idade`.
- Adiciona a propriedade `Nota`, representando o desempenho do aluno.
- O método `RepresentaNota()` valida se a nota está entre 0 e 10 e exibe uma mensagem apropriada.

**Comentário contextualizado:**
> O comentário no código destaca corretamente o uso de herança. A verificação de nota é uma boa prática para garantir integridade dos dados.

---

### 👨‍🏫 Classe `Professor`

```csharp
public class Professor : Pessoa
{
    public decimal Salario { get; set; }

    public void ApresentaSalario()
    {
        Console.WriteLine($"O salário informado é R$ {Salario}");
    }
}
```

**Descrição:**
- Também herda de `Pessoa`.
- Adiciona a propriedade `Salario`, representando a remuneração do professor.
- O método `ApresentaSalario()` exibe o valor do salário.

**Comentário contextualizado:**
> O comentário sobre herança está correto. A classe é simples e direta, ideal para fins didáticos.

---

## 🔁 Fluxo de Execução (`Program.cs`)

```csharp
Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1 - Aluno");
Console.WriteLine("2 - Professor");
Console.WriteLine("3 - Sair");
int opcao = int.Parse(Console.ReadLine());
```

**Descrição:**
- O programa inicia com um menu interativo.
- O usuário escolhe entre cadastrar um aluno, um professor ou encerrar o sistema.

### 🧠 Lógica de cada opção:

#### Opção 1 – Aluno:
- Instancia um objeto `Aluno`.
- Solicita nome, idade e nota.
- Chama os métodos `Apresentar()` e `RepresentaNota()`.

#### Opção 2 – Professor:
- Instancia um objeto `Professor`.
- Solicita nome, idade e salário.
- Chama os métodos `Apresentar()` e `ApresentaSalario()`.

#### Opção 3 – Sair:
- Exibe mensagem de encerramento.

**Comentário contextualizado:**
> O comentário sobre aguardar a entrada do usuário está adequado. O uso de `switch` torna o fluxo claro e organizado.

---

## 📝 Sugestões de Melhoria

- ✅ Validar entradas com `TryParse` para evitar exceções em caso de dados inválidos.
- ✅ Adicionar tratamento para entradas nulas ou vazias.
- ✅ Criar uma interface comum (ex: `IApresentavel`) para reforçar boas práticas de abstração.
- ✅ Separar lógica de entrada/saída da lógica de negócio para maior escalabilidade.

---

## 📚 Exemplo de Uso

```plaintext
Escolha uma opção:
1 - Aluno
2 - Professor
3 - Sair

Digite uma opção: 1
Digite o nome: Giancarlo
Digite a Idade: 30
Digite uma nota (0 a 10): 9.5

Nome: Giancarlo e Idade 30
A nota informada é 9.5
```

---
