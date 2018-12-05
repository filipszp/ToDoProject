﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface IAbstractService<T>
    {
        T saveNewEntity(T entity);
        T saveEntity(T entity);
        int deleteEntity(T entity);
        ICollection<T> findByNameField(string field, int userId = -1, string stringValue = "", int intValue = -1);
        ICollection<T> getAll(string sortField = "", SortOrder order = SortOrder.Ascending);
    }
}
