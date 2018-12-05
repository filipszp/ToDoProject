using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplicationLib.EntityModel
{
    public class Task
    {
        public virtual int Id { get; set; }
        public virtual string TaskName { get; set; }
        public virtual System.DateTime CreateDate { get; set; }
        public virtual User User { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }
        public virtual string Description { get; set; }
        public virtual System.DateTime TaskDate { get; set; }
        public virtual int Completed { get; set; }
        public virtual bool isNew { get; set; }
        public class TaskMap : ClassMap<Task>
        {
            public TaskMap()
            {
                Id(x => x.Id);
                Map(x => x.TaskName);
                Map(x => x.TaskDate);
                Map(x => x.CreateDate);
                Map(x => x.Description);
                Map(x => x.Completed);
                References(x => x.User);
                References(x => x.TaskCategory);
                Table("[Task]");
            }
        }
    }
}
