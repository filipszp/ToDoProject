using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplicationLib.EntityModel
{
    public class TaskCategory
    {
        public TaskCategory()
        {
            this.Tasks = new HashSet<Task>();
        }

        public virtual int Id { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }
        public virtual bool isNew { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public class TaskCategoryMap : ClassMap<TaskCategory>
        {
            public TaskCategoryMap()
            {
                Id(x => x.Id);
                Map(x => x.CategoryName);
                Map(x => x.Description);
                Table("[TaskCategory]");
            }
        }
    }
}
