using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface ITaskService
    {
        List<Task> GetAll();
        List<Task> GetTasksByUserId(int userId);
        Task GetEagerTaskById(int taskId);
        Task UpdateTask(Task task);
        List<Task> SearchTasks(TaskSearchCriteria searchCriteria, int userId);
    }
}
