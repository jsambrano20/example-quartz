using Quartz;

namespace ExampleQuartz
{
    public class MyJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            // Lógica que será executada quando o job for acionado 
            // Logic that will be executed when the job is triggered
            Console.WriteLine($"Running job at {DateTime.UtcNow}...");

            return Task.CompletedTask;
        }
    }
}
