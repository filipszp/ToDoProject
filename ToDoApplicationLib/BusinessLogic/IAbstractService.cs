using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface IAbstractService<T>
    {
        T baseSaveNewEntity(T entity);
        T basePersistEntity(T entity);
        int baseDeleteEntity(T entity);
        ICollection<T> baseFindByNameField(string field, int userId = -1, string stringValue = "", int intValue = -1);
        ICollection<T> baseGetAll(string sortField = "", SortOrder order = SortOrder.Ascending);
    }
}
