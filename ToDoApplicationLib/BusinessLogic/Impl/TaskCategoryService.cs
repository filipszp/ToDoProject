using System;
using System.Collections.Generic;
using System.Linq;
using TodoApplicationLib.Utils;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public class TaskCategoryService : AbstractService<TaskCategory>, ITaskCategoryService
    {
        public List<String> getAllCategoryName()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return (List<String>)session.CreateQuery("select c.CategoryName from TaskCategory c order by c.CategoryName").List<String>();
            }
        }

        public TaskCategory createTaskCategory(TaskCategory category)
        {
            return base.saveNewEntity(category);
        }

        public TaskCategory getCategoryByName(String categoryName)
        {
            return base.findByNameField("CategoryName", -1,categoryName).FirstOrDefault<TaskCategory>();
        }

        public int deleteTaskCategory(TaskCategory user)
        {
            throw new NotImplementedException();
        }

        public TaskCategory updateTaskCategory(TaskCategory taskCategory)
        {
            return base.saveEntity(taskCategory);
        }
    }
}
