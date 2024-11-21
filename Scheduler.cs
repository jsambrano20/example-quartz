using Quartz;
using Quartz.Impl;

namespace ExampleQuartz
{
    public class Scheduler
    {
        private readonly IScheduler _scheduler;

        public Scheduler()
        {
            // Obtém o scheduler padrão (Gets the default scheduler)
            _scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
        }

        public async Task StartSchedulerAsync()
        {
            // Inicia o scheduler (Starts the scheduler)
            await _scheduler.Start();

            // Cria o job (Creates the job)
            IJobDetail job = JobBuilder.Create<MyJob>()
                .WithIdentity("myJob", "group1") // Identidade do job (Job identity)
                .Build();

            // Cria o Trigger (agendando o job) (Creates the trigger for scheduling the job)
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .StartNow() // Começa imediatamente (Starts immediately)
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(10).RepeatForever())
                .Build();

            // Agenda o job com o trigger (Schedules the job with the trigger)
            await _scheduler.ScheduleJob(job, trigger);
        }
    }
}
