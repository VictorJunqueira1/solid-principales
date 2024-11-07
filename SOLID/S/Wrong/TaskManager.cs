using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.S.Wrong
{
    public class TaskManager
    {
        public void AddTask(string taskName)
        {
            // Lógica para adicionar uma tarefa
            Console.WriteLine($"Task '{taskName}' adicionada.");
        }
    
        public void PrintReport()
        {
            // Lógica para imprimir o relatório de tarefas
            Console.WriteLine("Imprimindo relatório de tarefas...");
        }
    }
}

// Problema: A classe TaskManager possui duas responsabilidades – gerenciar tarefas e gerar relatórios. 
// Isso viola o SRP (Solid Responsability Principale).