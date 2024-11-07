using System;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===========================================");
            Console.WriteLine("       Aprenda os Princípios SOLID       ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\nBem-vindo ao projeto de exemplos dos princípios SOLID!");
            Console.WriteLine("SOLID é um conjunto de princípios de design de código para ajudar na criação de sistemas mais manuteníveis e extensíveis.\n");
            Console.WriteLine("Pressione qualquer tecla para ver o primeiro princípio...");
            Console.ReadKey();

            ShowSRP();
        }

        static void ShowSRP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========================================");
            Console.WriteLine("  Princípio 1: Single Responsibility Principle (SRP) ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\nO SRP afirma que uma classe deve ter uma única razão para mudar.");
            Console.WriteLine("Isso significa que uma classe deve ser responsável por uma única funcionalidade.\n");

            Console.WriteLine("Exemplo de implementação errada: Uma classe que gerencia tanto a criação de tarefas quanto a impressão de relatórios.");
            Console.WriteLine("Exemplo de implementação correta: Dividir essa responsabilidade em duas classes, uma para gerenciar tarefas e outra para gerar relatórios.\n");

            Console.WriteLine("Pressione qualquer tecla para continuar para o próximo princípio...");
            Console.ReadKey();

            ShowOCP();
        }

        static void ShowOCP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===========================================");
            Console.WriteLine("  Princípio 2: Open/Closed Principle (OCP) ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\nO OCP diz que uma classe deve ser aberta para extensão, mas fechada para modificação.");
            Console.WriteLine("Ou seja, podemos adicionar novos comportamentos sem modificar a classe existente.\n");

            Console.WriteLine("Exemplo de implementação errada: Modificar a classe para adicionar novos tipos de descontos.");
            Console.WriteLine("Exemplo de implementação correta: Criar uma interface que permita estender novos tipos de desconto sem alterar a classe original.\n");

            Console.WriteLine("Pressione qualquer tecla para continuar para o próximo princípio...");
            Console.ReadKey();

            ShowLSP();
        }

        static void ShowLSP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===========================================");
            Console.WriteLine("  Princípio 3: Liskov Substitution Principle (LSP) ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\nO LSP afirma que objetos de uma classe derivada devem ser substituíveis por objetos da classe base.");
            Console.WriteLine("Ou seja, a classe derivada não deve alterar o comportamento esperado da classe base.\n");

            Console.WriteLine("Exemplo de implementação errada: Uma classe `Square` que herda de `Rectangle`, mas se comporta de forma inadequada.");
            Console.WriteLine("Exemplo de implementação correta: Usar uma interface comum para formas geométricas, sem herança incorreta.\n");

            Console.WriteLine("Pressione qualquer tecla para continuar para o próximo princípio...");
            Console.ReadKey();

            ShowISP();
        }

        static void ShowISP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===========================================");
            Console.WriteLine("  Princípio 4: Interface Segregation Principle (ISP) ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\nO ISP diz que uma classe não deve ser forçada a implementar métodos que ela não usa.");
            Console.WriteLine("Interfaces devem ser específicas para cada tipo de cliente.\n");

            Console.WriteLine("Exemplo de implementação errada: Forçar uma classe a implementar métodos desnecessários em uma interface genérica.");
            Console.WriteLine("Exemplo de implementação correta: Criar interfaces específicas para cada tipo de notificação (ex. `IEmailNotification`, `ISmsNotification`).\n");

            Console.WriteLine("Pressione qualquer tecla para continuar para o próximo princípio...");
            Console.ReadKey();

            ShowDIP();
        }

        static void ShowDIP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===========================================");
            Console.WriteLine("  Princípio 5: Dependency Inversion Principle (DIP) ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("\nO DIP afirma que módulos de alto nível não devem depender de módulos de baixo nível.");
            Console.WriteLine("Ambos devem depender de abstrações, como interfaces.\n");

            Console.WriteLine("Exemplo de implementação errada: A classe `UserManager` depende diretamente de uma classe concreta `MySqlUserRepository`.");
            Console.WriteLine("Exemplo de implementação correta: `UserManager` depende de uma interface `IUserRepository`, permitindo a troca de implementações facilmente (por exemplo, para `PostgreSqlUserRepository`).\n");

            Console.WriteLine("Parabéns! Você aprendeu os princípios SOLID.");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}