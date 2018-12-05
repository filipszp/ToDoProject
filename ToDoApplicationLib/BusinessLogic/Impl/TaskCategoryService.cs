using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public class TaskCategoryService : AbstractService<TaskCategory>, ITaskCategoryService
    {
        public List<String> GetAllCategoryName()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return (List<String>)session.CreateQuery("select c.CategoryName from TaskCategory c order by c.CategoryName").List<String>();
            }
        }

        public TaskCategory CreateTaskCategory(TaskCategory category)
        {
            return base.baseSaveNewEntity(category);
        }

        public TaskCategory GetCategoryByName(String categoryName)
        {
            return base.baseFindByNameField("CategoryName", -1, categoryName).FirstOrDefault<TaskCategory>();
        }

        public int DeleteTaskCategory(TaskCategory taskCategory)
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
                return base.baseDeleteEntity(taskCategory);
            }
        }

        public TaskCategory UpdateTaskCategory(TaskCategory taskCategory)
        {
            return base.basePersistEntity(taskCategory);
        }

        public List<TaskCategory> GetAll()
        {
            return (List<TaskCategory>)base.baseGetAll();
        }
    }
}
