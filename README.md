# Projeto: Exemplos de Princípios SOLID em C#

Este repositório apresenta exemplos práticos e comentados dos cinco princípios SOLID em C#. A intenção é demonstrar a importância de cada princípio para a criação de um código mais **modular**, **manutenível** e **extensível**, com comparações de implementações corretas e incorretas.

## Índice

- [Introdução aos Princípios SOLID](#introdução-aos-princípios-solid)
  - [Single Responsibility Principle (SRP)](#single-responsibility-principle-srp)
  - [Open/Closed Principle (OCP)](#openclosed-principle-ocp)
  - [Liskov Substitution Principle (LSP)](#liskov-substitution-principle-lsp)
  - [Interface Segregation Principle (ISP)](#interface-segregation-principle-isp)
  - [Dependency Inversion Principle (DIP)](#dependency-inversion-principle-dip)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Como Executar](#como-executar)
- [Contribuições](#contribuições)

---

## Introdução aos Princípios SOLID

Os princípios SOLID são uma coleção de diretrizes que ajudam a melhorar o design de software, promovendo o desenvolvimento de código mais limpo e modular. Concebidos por Robert C. Martin, esses princípios são fundamentais para a criação de sistemas mais robustos.

1. **Single Responsibility Principle (SRP)**: Uma classe deve ter uma única razão para mudar, pois cada classe deve possuir uma única responsabilidade.
2. **Open/Closed Principle (OCP)**: O software deve ser aberto para extensão, mas fechado para modificação, permitindo adições de funcionalidade sem alterar o código existente.
3. **Liskov Substitution Principle (LSP)**: As subclasses devem poder substituir suas classes base sem alterar o comportamento do sistema.
4. **Interface Segregation Principle (ISP)**: As classes não devem ser forçadas a implementar interfaces que elas não utilizam.
5. **Dependency Inversion Principle (DIP)**: Módulos de alto nível não devem depender de módulos de baixo nível, mas sim de abstrações.

### Exemplos no Projeto

Para cada princípio, o projeto inclui um exemplo prático de uma implementação **errada** (que viola o princípio) e uma **correta** (que adere ao princípio).

---

### Single Responsibility Principle (SRP)

**Descrição:** Este princípio afirma que uma classe deve ter uma única responsabilidade e, consequentemente, apenas uma razão para ser modificada.

**Exemplo:** Um sistema de gerenciamento de tarefas onde a classe `TaskManager` acumula funções de criação e geração de relatórios.

- **Implementação Errada:** `TaskManager` realiza múltiplas tarefas (gerenciamento e geração de relatórios).
- **Implementação Correta:** As responsabilidades são separadas em duas classes: `TaskManager` para gerenciar as tarefas e `TaskReport` para criar relatórios.

---

### Open/Closed Principle (OCP)

**Descrição:** As classes devem ser abertas para extensão, mas fechadas para modificação. Novas funcionalidades devem ser adicionadas sem alterar o código existente.

**Exemplo:** Um sistema de cálculo de descontos onde, na versão errada, `DiscountCalculator` usa uma estrutura condicional para cada tipo de desconto.

- **Implementação Errada:** `DiscountCalculator` é alterado sempre que um novo tipo de desconto é adicionado.
- **Implementação Correta:** Uso de uma interface `IDiscount`, permitindo que novos tipos de desconto sejam implementados sem alterar o `DiscountCalculator`.

---

### Liskov Substitution Principle (LSP)

**Descrição:** As subclasses devem poder substituir suas classes base sem problemas no comportamento do programa.

**Exemplo:** Sistema de formas geométricas onde `Square` herda de `Rectangle`, o que causa inconsistências.

- **Implementação Errada:** `Square` herda de `Rectangle` e altera o comportamento esperado dos métodos da classe base.
- **Implementação Correta:** `Square` e `Rectangle` são implementados de forma independente, com ambos usando a interface `IShape`, respeitando o comportamento esperado.

---

### Interface Segregation Principle (ISP)

**Descrição:** Classes não devem ser forçadas a implementar métodos que elas não precisam. Este princípio sugere que interfaces mais específicas são preferíveis.

**Exemplo:** Sistema de notificações onde uma interface `INotification` força todas as classes a implementarem métodos desnecessários.

- **Implementação Errada:** `INotification` inclui métodos que nem todas as classes usam.
- **Implementação Correta:** Interfaces menores como `IEmailNotification` e `ISmsNotification` são criadas, permitindo que classes implementem apenas os métodos relevantes.

---

### Dependency Inversion Principle (DIP)

**Descrição:** Módulos de alto nível não devem depender de módulos de baixo nível, mas sim de abstrações. Isso permite maior flexibilidade ao trocar implementações.

**Exemplo:** Um sistema onde `UserManager` depende diretamente de `MySqlUserRepository` para salvar dados, tornando difícil a troca para outro banco.

- **Implementação Errada:** `UserManager` depende de uma classe concreta (`MySqlUserRepository`), o que cria um acoplamento forte.
- **Implementação Correta:** `UserManager` depende de uma interface `IUserRepository`, possibilitando a troca entre `MySqlUserRepository` e `PostgreSqlUserRepository` sem alterar o código do `UserManager`.

---

## Estrutura de Pastas do Projeto

A estrutura de pastas do projeto foi organizada para refletir os princípios SOLID, facilitando o entendimento das implementações corretas e incorretas de cada princípio. Abaixo está uma explicação detalhada sobre como as pastas estão estruturadas.

### Pasta Raiz (`SOLID`)

A pasta principal do projeto é chamada `SOLID` e contém os exemplos de código relacionados a cada um dos cinco princípios SOLID. Dentro dessa pasta, há subpastas para cada princípio, garantindo uma separação clara e bem organizada.

### Subpastas para Cada Princípio

Para cada princípio SOLID, há uma subpasta dedicada, nomeada de acordo com o princípio. As pastas são as seguintes:

- **SRP** (Single Responsibility Principle)
- **OCP** (Open/Closed Principle)
- **LSP** (Liskov Substitution Principle)
- **ISP** (Interface Segregation Principle)
- **DIP** (Dependency Inversion Principle)

Cada uma dessas pastas contém exemplos específicos que demonstram como o princípio pode ser aplicado no código.

### Divisão entre Implementações Corretas e Incorretas

Dentro de cada pasta de princípio, temos duas subpastas adicionais:

- **Correct**: Esta subpasta contém a implementação que segue corretamente o princípio SOLID.
- **Wrong**: Aqui ficam as implementações que violam o princípio, permitindo visualizar os erros e entender as consequências de não seguir as boas práticas.

### Arquivos de Exemplo

Cada subpasta pode conter vários arquivos de código C# que demonstram o cenário relacionado. Por exemplo:

- **SRP**: A pasta `Correct` pode conter arquivos como `TaskManager.cs` e `TaskReport.cs`, onde `TaskManager` gerencia as tarefas e `TaskReport` é responsável apenas pelos relatórios. Já a pasta `Wrong` teria um único arquivo, `TaskManager.cs`, que violaria o SRP ao gerenciar tanto tarefas quanto relatórios.
  
- **DIP**: No caso do `Dependency Inversion Principle`, a pasta `Correct` pode conter arquivos como `IUserRepository.cs`, `MySqlUserRepository.cs`, `PostgreSqlUserRepository.cs` e `UserManager.cs`, onde a classe `UserManager` depende de abstrações (`IUserRepository`), permitindo a troca fácil entre implementações de banco de dados. Na pasta `Wrong`, teríamos implementações mais rígidas, com `UserManager.cs` dependendo diretamente de `MySqlUserRepository` e `PostgreSqlUserRepository`, o que dificultaria a troca entre os bancos de dados.

### Benefícios dessa Estrutura

- **Clareza**: A separação entre implementações corretas e incorretas ajuda a entender claramente os efeitos de seguir ou não os princípios SOLID.
- **Organização**: A estrutura modular permite a fácil navegação pelos exemplos, e cada princípio tem sua própria pasta, garantindo que o projeto seja organizado e fácil de entender.
- **Aprendizado Didático**: Ao visualizar as implementações corretas e incorretas lado a lado, o usuário pode aprender tanto as boas práticas quanto os erros comuns a serem evitados.

Cada diretório possui uma implementação incorreta e uma correta para cada princípio, ilustrando como aplicar os conceitos SOLID para melhorar o design de software.

## Como Executar

1. Clone este repositório para sua máquina local.
2. Abra o projeto em uma IDE compatível com C# (como Visual Studio ou Rider).
3. Navegue até o exemplo desejado no diretório do princípio SOLID.
4. Compile e execute o código para ver as diferenças entre as implementações corretas e incorretas.

Cada classe possui comentários detalhados para facilitar o entendimento de cada princípio.

---

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para submeter exemplos adicionais ou melhorar os existentes. Para contribuir:

1. Crie uma **issue** para discutir o que gostaria de adicionar ou modificar.
2. Envie um **pull request** com as alterações.

---

Esperamos que este projeto ajude você a entender como os princípios SOLID podem ser aplicados para criar código mais robusto, flexível e fácil de manter. Bons estudos!