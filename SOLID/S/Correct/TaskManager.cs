using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.S.Correct
{
    public class TaskManager
    {
        public void AddTask(string taskName)
        {
            // Lógica para adicionar uma tarefa
            Console.WriteLine($"Task '{taskName}' adicionada.");
        }
    }
}