using System;
using System.Threading.Tasks;

namespace ExampleQuartz
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Criação do Scheduler
            Scheduler scheduler = new Scheduler();
            
            // Iniciar o agendador
            await scheduler.StartSchedulerAsync();

            // Aguarda a execução do job
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
