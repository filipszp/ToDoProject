using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface ITaskService
    {
        List<Task> getTasksByUserId(int userId);

        Task updateTask(Task task);
    }
}
