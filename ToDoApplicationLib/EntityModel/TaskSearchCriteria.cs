using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplicationLib.EntityModel
{
    public class TaskSearchCriteria
    {
        public string TaskName { get; set; }
        public DateTime? TaskDateFrom { get; set; }
        public DateTime? TaskDateTo { get; set; }
        public String TaskCategory { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("   #TaskSearchCriteria: ");
            if (!String.IsNullOrEmpty(TaskName))
                stringBuilder.AppendLine("TaskName: " + TaskName);
            if (TaskDateFrom.HasValue)
                stringBuilder.AppendLine("TaskDateFrom: " + TaskDateFrom.Value);
            if (TaskDateTo.HasValue)
                stringBuilder.AppendLine("TaskDateTo: " + TaskDateTo.Value);
            if (TaskCategory != null)
                stringBuilder.AppendLine("TaskCategory: " + TaskCategory);

            return stringBuilder.ToString();
        }
    }

}
