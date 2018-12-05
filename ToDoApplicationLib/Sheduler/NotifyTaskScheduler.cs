using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApplicationLib.Sheduler
{
    public class NotifyTaskScheduler
    {
        public static async Task RunTaskCheckerAsync()
        {
            try
            {
                NameValueCollection props = new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                };
                StdSchedulerFactory factory = new StdSchedulerFactory(props);
                IScheduler scheduler = await factory.GetScheduler();

                await scheduler.Start();

                IJobDetail job = JobBuilder.Create<TaskChecker>()
                    .WithIdentity("taskChecker", "group")
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("taskTrigger", "group")
                    .StartNow()
                    .WithSimpleSchedule(x => x
                        .WithIntervalInSeconds(5)  //interwal schedulera w sekundach
                        .RepeatForever())
                    .Build();

                await scheduler.ScheduleJob(job, trigger);
            }
            catch (SchedulerException se)
            {
                Console.WriteLine(se);
            }
        }

        public static IDisposable OpenNestedContext(string message)
        {
            throw new NotImplementedException();
        }

        public static IDisposable OpenMappedContext(string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}
