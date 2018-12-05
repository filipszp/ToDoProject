using System;
using System.Collections.Generic;
using System.Linq;
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
            return base.findByNameField("CategoryName", -1, categoryName).FirstOrDefault<TaskCategory>();
        }

        public int deleteTaskCategory(TaskCategory taskCategory)
        {
            var refTasks = new List<Task>();
            using (var session = NHibernateHelper.OpenSession())
            {
                refTasks = (List<Task>)session.Query<Task>()
                   .Where(t => t.TaskCategory.Id == taskCategory.Id)
                   .ToList();
            }
            if (refTasks.Count != 0)
            {
                return -1;
            }
            else
            {
                return base.deleteEntity(taskCategory);
            }
        }

        public TaskCategory updateTaskCategory(TaskCategory taskCategory)
        {
            return base.saveEntity(taskCategory);
        }

        public List<TaskCategory> getAll()
        {
            return (List<TaskCategory>)base.getAll();
        }
    }
}
