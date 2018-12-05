using System;
using System.Collections.Generic;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface IUserService
    {
        List<String> GetAllLogin();
        User CreateUser(User user);
        User Login(User user);
        User LastLoginTimeUpdate(User user);

    }
}
