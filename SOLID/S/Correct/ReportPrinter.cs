using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.S.Correct
{
    public class ReportPrinter
    {
        public void PrintReport()
        {
            // Lógica para imprimir o relatório de tarefas
            Console.WriteLine("Imprimindo relatório de tarefas...");
        }
    }
}

// Correção: As responsabilidades foram separadas. 
// TaskManager cuida das tarefas, enquanto ReportPrinter cuida da geração de relatórios.