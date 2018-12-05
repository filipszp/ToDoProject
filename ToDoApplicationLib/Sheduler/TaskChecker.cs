using Quartz;
using System;
using System.Linq;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.Sheduler
{
    public class TaskChecker : IJob
    {
        private int x;
        public async System.Threading.Tasks.Task Execute(IJobExecutionContext context)
        {
            x = 1;
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(10));
            await checkTasks();
        }

        private async System.Threading.Tasks.Task checkTasks()
        {
          /*  using (DbEntities ctx = new DbEntities())
            {
                ctx.Tasks.ToList<Task>().ForEach(t =>
                {
                    if (t.Completed == 1)
                    {
                        t.TaskName = "changeName "+x;
                        Console.Out.WriteLine("change task name! "+x);
                        x++;
                    }
                });
                //await ctx.SaveChangesAsync();
                await Console.Out.WriteAsync("async writeLine");
            }
            */
        }

    }
}
