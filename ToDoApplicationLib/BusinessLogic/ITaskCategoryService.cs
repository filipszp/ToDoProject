using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface ITaskCategoryService
    {
        List<String> GetAllCategoryName();
        List<TaskCategory> GetAll();
        TaskCategory GetCategoryByName(String categoryName);
        TaskCategory CreateTaskCategory(TaskCategory user);
        int DeleteTaskCategory(TaskCategory taskCategory);
        TaskCategory UpdateTaskCategory(TaskCategory taskCategory);
    }
}
