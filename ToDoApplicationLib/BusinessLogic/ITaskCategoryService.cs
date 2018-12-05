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
        List<String> getAllCategoryName();
        List<TaskCategory> getAll();
        TaskCategory getCategoryByName(String categoryName);
        TaskCategory createTaskCategory(TaskCategory user);
        int deleteTaskCategory(TaskCategory taskCategory);
        TaskCategory updateTaskCategory(TaskCategory taskCategory);
    }
}
