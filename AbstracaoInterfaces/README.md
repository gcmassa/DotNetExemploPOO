
---

# 📘 Documentação Técnica – Projeto Abstração e Interfaces em C#

## 🧩 Visão Geral

Este projeto demonstra conceitos fundamentais da programação orientada a objetos (POO) em C#, como herança, abstração, sobrescrita de métodos, construtores, encapsulamento e polimorfismo. As classes estão organizadas no namespace `AbstracaoInterfaces.models`, e o ponto de entrada da aplicação está no arquivo `Program.cs`.

---

## 👤 Classe `Pessoa`

### Objetivo
Representa uma entidade genérica com atributos básicos de uma pessoa.

### Estrutura
- **Construtores**
  - `Pessoa()` – Permite instanciar uma pessoa sem obrigatoriedade de definir o nome.
  - `Pessoa(string nome)` – Exige que o nome seja informado na criação do objeto.
- **Propriedades**
  - `Nome`, `Idade`, `Email` – Atributos públicos com `get` e `set`.
- **Método**
  - `Apresentar()` – Método virtual que imprime uma saudação com nome e idade.

### Conceitos Aplicados
- Sobrescrita permitida via `virtual`.
- Encapsulamento com propriedades públicas.
- Flexibilidade de instanciamento com múltiplos construtores.

---

## 🎓 Classe `Aluno`

### Objetivo
Especialização da classe `Pessoa` que representa um aluno.

### Estrutura
- Herda de `Pessoa`.
- Adiciona a propriedade `Nota`.
- Sobrescreve o método `Apresentar()` para incluir a nota.

### Conceitos Aplicados
- **Herança**: `Aluno` herda atributos e métodos de `Pessoa`.
- **Construtor com base**: `Aluno(string nome)` chama o construtor da classe base.
- **Polimorfismo**: Sobrescreve `Apresentar()` para comportamento específico.

---

## 👨‍🏫 Classe `Professor`

### Objetivo
Especialização de `Pessoa` que representa um professor.

### Estrutura
- Herda de `Pessoa`.
- Adiciona a propriedade `Salario`.
- Sobrescreve o método `Apresentar()` para incluir salário.

### Comentários Relevantes
- O uso comentado de `sealed` indica que a classe poderia ser selada para impedir herança.
- O método `Apresentar()` também poderia ser selado com `sealed override`.

### Conceitos Aplicados
- Herança e polimorfismo.
- Possibilidade de selar classe e método para restringir extensibilidade.

---

## 🧑‍💼 Classe `Diretor`

### Objetivo
Especialização de `Professor` que representa um diretor.

### Estrutura
- Herda de `Professor`.
- Sobrescreve `Apresentar()` com mensagem específica.

### Conceitos Aplicados
- Herança em múltiplos níveis (`Pessoa` → `Professor` → `Diretor`).
- Polimorfismo com sobrescrita.

---

## 💳 Classe `Conta` (Abstrata)

### Objetivo
Modelo genérico de uma conta bancária.

### Estrutura
- `saldo` como campo protegido.
- Método abstrato `Creditar(decimal valor)` – exige implementação nas classes derivadas.
- Método concreto `ExibirSaldo()` – exibe o saldo atual.

### Conceitos Aplicados
- **Abstração**: Classe não pode ser instanciada diretamente.
- **Encapsulamento**: `saldo` protegido.
- **Polimorfismo**: Método abstrato obriga implementação específica.

---

## 🏦 Classe `Corrente`

### Objetivo
Implementa uma conta corrente.

### Estrutura
- Herda de `Conta`.
- Implementa `Creditar()` somando valor ao saldo.

### Comentário Relevante
- O método `Creditar()` é obrigatório devido à herança de `Conta`.

### Conceitos Aplicados
- Implementação de método abstrato.
- Herança e encapsulamento.

---

## 💻 Classe `Computador`

### Objetivo
Classe simples que demonstra sobrescrita do método `ToString()`.

### Estrutura
- Sobrescreve `ToString()` para retornar uma string personalizada.

### Conceitos Aplicados
- Herança implícita de `System.Object`.
- Sobrescrita de método padrão do .NET.

---

## 🧪 Arquivo `Program.cs`

### Objetivo
Ponto de entrada da aplicação. Demonstra instanciamento e uso das classes.

### Fluxo
1. Cria uma conta corrente, credita valor e exibe saldo.
2. Instancia um professor e um aluno com nomes específicos.
3. Chama o método `Apresentar()` para ambos.
4. Cria um objeto `Computador` e exibe o resultado de `ToString()`.

### Conceitos Demonstrados
- Instanciamento de objetos.
- Uso de construtores com e sem parâmetros.
- Polimorfismo em ação com `Apresentar()`.
- Herança implícita de `System.Object`.

---

## ✅ Conclusão

Este conjunto de classes ilustra com clareza os pilares da programação orientada a objetos em C#. A estrutura hierárquica entre `Pessoa`, `Aluno`, `Professor` e `Diretor` mostra como a herança e o polimorfismo permitem reutilização e especialização de comportamentos. A abstração com `Conta` e sua implementação em `Corrente` reforça a importância de definir contratos obrigatórios para subclasses. Por fim, a sobrescrita de `ToString()` em `Computador` evidencia como até os métodos herdados de `System.Object` podem ser personalizados.

A aplicação está bem segmentada e os comentários ajudam a contextualizar cada decisão de design, tornando o código didático e funcional.
