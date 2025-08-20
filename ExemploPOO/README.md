
---

## 🧍 Classe `Pessoa` – Abstração e Simples Encapsulamento

### 📌 Código:
```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá! meu nome é {Nome} e tenho idade {Idade} anos!");
    }
}
```

### 🧠 Conceitos abordados:
- **Abstração**: A classe representa uma pessoa com propriedades essenciais (nome e idade) e um comportamento (`Apresentar`).
- **Encapsulamento básico**: As propriedades são públicas com `get` e `set`, permitindo acesso direto. Embora não seja o encapsulamento mais seguro, é funcional para fins didáticos.

### 💬 Observação:
Você poderia tornar o encapsulamento mais robusto usando campos privados e métodos públicos para acesso, se quisesse controlar melhor os dados.

---

## 🏦 Classe `ContaCorrente` – Encapsulamento e Construtor

### 📌 Código:
```csharp
public class ContaCorrente
{
    public ContaCorrente(int numeroConta, decimal saldoInicial)
    {
        NumeroConta = numeroConta;
        saldo = saldoInicial;
    }

    public int NumeroConta { get; set; }
    private decimal saldo;

    public void Sacar(decimal valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor desejado é maior que saldo disponível");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine("Seu saldo disponível é: " + saldo);
    }
}
```

### 🧠 Conceitos abordados:
- **Encapsulamento**: O campo `saldo` é privado, então só pode ser acessado ou modificado por métodos da própria classe.
- **Construtor**: Inicializa a conta com número e saldo.
- **Validação interna**: O método `Sacar` protege o estado da conta contra saques indevidos.

### 💬 Sugestão:
Você poderia adicionar um método `Depositar` para completar as operações básicas de uma conta.

---

## 🧪 `Program.cs` – Instanciação e Execução

### 📌 Código:
```csharp
Pessoa p1 = new Pessoa();
p1.Nome = "Giancarlo";
p1.Idade = 44;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();
```

### 🧠 Conceitos abordados:
- **Instanciação de objetos**: Criação de `Pessoa` e `ContaCorrente`.
- **Encapsulamento em prática**: O saldo só é acessado por métodos da classe.
- **Fluxo lógico**: Demonstra como os métodos alteram o estado interno do objeto.

---

## ✅ Resumo dos conceitos aplicados

| Conceito         | Onde aparece                   | Descrição                                                                 |
|------------------|--------------------------------|---------------------------------------------------------------------------|
| Abstração        | `Pessoa`, `ContaCorrente`      | Representa entidades reais com atributos e comportamentos                 |
| Encapsulamento   | `ContaCorrente` (campo `saldo`) | Protege dados internos da classe                                          |
| Construtor       | `ContaCorrente`                | Inicializa o objeto com valores definidos                                |
| Métodos          | `Apresentar`, `Sacar`, `ExibirSaldo` | Definem comportamentos específicos para os objetos                        |
| Instanciação     | `Program.cs`                   | Criação e uso de objetos                                                  |

---

