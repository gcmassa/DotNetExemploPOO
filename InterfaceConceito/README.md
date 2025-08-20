
---

# 📘 Documentação Técnica – Projeto InterfaceConceito

## 🧩 Visão Geral

Este projeto apresenta o conceito de interfaces em C#, demonstrando como elas definem contratos que devem ser implementados por classes. A interface `ICalculadora` estabelece os métodos esperados, e a classe `Calculadora` fornece suas implementações. O `Program.cs` mostra como utilizar a interface para instanciar e operar a calculadora.

---

## 🧮 Interface `ICalculadora`

### Objetivo
Define um contrato para operações matemáticas básicas que qualquer classe calculadora deve implementar.

### Estrutura
- Métodos definidos:
  - `int Somar(int num1, int num2)`
  - `int Subtrair(int num1, int num2)`
  - `int Multiplicar(int num1, int num2)`
  - `int Dividir(int num1, int num2)`

### Comentário Relevante
> “lista métodos que não têm corpo que precisam ser implementados na classe Calculadora”

### Conceitos Aplicados
- **Interface**: Define apenas a assinatura dos métodos, sem implementação.
- **Contratualidade**: Qualquer classe que implemente `ICalculadora` é obrigada a fornecer a lógica de cada método.

---

## 🧠 Classe `Calculadora`

### Objetivo
Implementa a interface `ICalculadora`, fornecendo a lógica para operações matemáticas.

### Estrutura
- Implementa todos os métodos da interface:
  - `Somar`, `Subtrair`, `Multiplicar`, `Dividir`
- Cada método realiza a operação correspondente e retorna o resultado.

### Comentário Relevante
> “Calculadora implementa a ICalculadora”  
> Dica prática para o Visual Studio Code: usar `Ctrl + .` para gerar automaticamente os métodos da interface.

### Conceitos Aplicados
- **Implementação de Interface**: A classe cumpre o contrato definido por `ICalculadora`.
- **Encapsulamento de lógica**: Cada operação é isolada em seu respectivo método.
- **Polimorfismo por interface**: Permite que objetos sejam manipulados por meio da interface, não da classe concreta.

---

## 🧪 Arquivo `Program.cs`

### Objetivo
Ponto de entrada da aplicação. Demonstra o uso da interface e da classe implementadora.

### Fluxo
1. Cria uma instância de `Calculadora` usando o tipo da interface `ICalculadora`.
2. Executa o método `Multiplicar(3, 7)` e imprime o resultado no console.

### Conceitos Demonstrados
- **Programação orientada a interfaces**: O objeto é declarado como `ICalculadora`, promovendo flexibilidade e desacoplamento.
- **Execução de método**: Chamada direta ao método implementado via interface.

---

## ✅ Conclusão

Este projeto é uma representação clara e objetiva do uso de interfaces em C#. A interface `ICalculadora` define um contrato que a classe `Calculadora` cumpre integralmente, demonstrando como separar definição de comportamento da implementação. O uso da interface no `Program.cs` reforça boas práticas de design, como o princípio da inversão de dependência, permitindo que o código seja mais flexível e testável.

A estrutura é simples, mas poderosa, e os comentários ajudam a contextualizar tanto o uso prático no ambiente de desenvolvimento quanto os conceitos teóricos por trás da implementação.
