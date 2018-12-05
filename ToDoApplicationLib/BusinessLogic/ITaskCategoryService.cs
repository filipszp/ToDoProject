﻿using System;
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
        TaskCategory getCategoryByName(String categoryName);
        TaskCategory createTaskCategory(TaskCategory user);
        int deleteTaskCategory(TaskCategory user);
        TaskCategory updateTaskCategory(TaskCategory taskCategory);
    }
}
