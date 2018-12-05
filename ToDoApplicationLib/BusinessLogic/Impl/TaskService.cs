using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic.Impl
{
    public class TaskService : AbstractService<Task>, ITaskService
    {

        public List<Task> GetAll()
        {
            var list = base.getAll();
            return (List<Task>)list;
        }

        public List<Task> GetTasksByUserId(int userId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var list = session.Query<Task>()
                    .Fetch(t => t.User)
                    .Fetch(t => t.TaskCategory)
                    .Where(t => t.User.Id == userId)
                    .OrderByDescending(t => t.TaskDate)
                    .ToList<Task>();
                return list;
            }
        }

        public Task GetEagerTaskById(int taskId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var task = session.Query<Task>()
                .Where(t => t.Id == taskId)
                .Fetch(t => t.User)
                .Fetch(t => t.TaskCategory)
                .FirstOrDefault<Task>();

                return task;
            }
        }

        public Task UpdateTask(Task task)
        {
            return base.saveEntity(task);
        }

        public List<Task> SearchTasks(TaskSearchCriteria searchCriteria, int userId)
        {
            var searchTasks = new List<Task>();
            using (var session = NHibernateHelper.OpenSession())
            {
                ICriterion crTaskName = null;

                ICriterion crDateBetween = null;
                ICriterion crTaskCategory = null;
                ICriterion crAllOr = null;

                if (!String.IsNullOrEmpty(searchCriteria.TaskName))
                {
                    crTaskName = Restrictions.Like("t.TaskName", "%" + searchCriteria.TaskName + "%");
                }

                if (searchCriteria.TaskDateFrom.HasValue && searchCriteria.TaskDateTo.HasValue)
                    crDateBetween = Restrictions.Between("t.TaskDate", searchCriteria.TaskDateFrom.Value, searchCriteria.TaskDateTo.Value);

                if (!String.IsNullOrEmpty(searchCriteria.TaskCategory))
                    crTaskCategory = Restrictions.Eq("c.CategoryName", searchCriteria.TaskCategory);


                if (crTaskName != null && crDateBetween != null && crTaskCategory != null)
                {
                    crAllOr = Restrictions.Disjunction()
                        .Add(crTaskName)
                        .Add(crTaskCategory)
                        .Add(crDateBetween);
                }
                if (crTaskName != null && crTaskCategory == null && crDateBetween == null)
                {
                    crAllOr = crTaskName;
                }
                if (crTaskName != null & crTaskCategory != null && crDateBetween == null)
                {
                    crAllOr = Restrictions.Disjunction()
                        .Add(crTaskName)
                        .Add(crTaskCategory);
                }
                if (crTaskName != null && crTaskCategory == null && crDateBetween != null)
                {
                    crAllOr = Restrictions.Disjunction()
                       .Add(crTaskName)
                       .Add(crDateBetween);
                }
                if (crTaskName == null && crTaskCategory != null && crDateBetween != null)
                {
                    crAllOr = Restrictions.Disjunction()
                       .Add(crTaskCategory)
                       .Add(crDateBetween);
                }
                if (crTaskName == null && crTaskCategory == null && crDateBetween != null)
                {
                    crAllOr = Restrictions.Disjunction()
                       .Add(crDateBetween);
                }
                if (crTaskName == null && crTaskCategory != null && crDateBetween == null)
                {
                    crAllOr = Restrictions.Disjunction()
                       .Add(crTaskCategory);
                }

                var query = session.CreateCriteria<Task>("t");
                    //.Fetch(SelectMode.Fetch, "t.TaskCategory","c")
                    //.Fetch(SelectMode.Fetch, "t.User","u");

                query.CreateCriteria("t.TaskCategory", "c");
                query.CreateCriteria("t.User", "u");

                ICriterion crUserId = Restrictions.Eq("u.Id", userId);
                ICriterion crEndAll = null;
                if (crAllOr != null)
                    crEndAll = Restrictions.And(crUserId, crAllOr);
                else
                    crEndAll = crUserId;
                query.Add(crEndAll);

                searchTasks = query.List<Task>().ToList<Task>();
            }
            return searchTasks;
        }

    }
}