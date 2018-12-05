using System;
using System.Collections.Generic;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public interface IUserService
    {
        List<String> getAllLogin();
        User createUser(User user);
        //int deleteUser(User user);
        User login(User user);
        User lastLoginTimeUpdate(User user);

    }
}
