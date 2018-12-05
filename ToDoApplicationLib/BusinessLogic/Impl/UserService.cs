using System;
using System.Collections.Generic;
using System.Linq;
using TodoApplicationLib.Utils;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib.BusinessLogic
{
    public class UserService : AbstractService<User>, IUserService
    {
        public List<String> GetAllLogin()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return (List<String>)session.CreateQuery("select u.Login from User u order by u.Login").List<String>();
            }
        }

        public User CreateUser(User user)
        {
            return base.baseSaveNewEntity(user);
        }

        public int deleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Login(User user)
        {
            var userFromDb = new User();
            using (var session = NHibernateHelper.OpenSession())
            {
                userFromDb = session.Query<User>()
                    .Where(u => u.Login == user.Login)
                    .FirstOrDefault<User>();

                if (userFromDb == null)
                    return userFromDb;
                else
                {
                    if (PasswordCrypto.Decrypt(userFromDb.Password).Equals(user.Password))
                        userFromDb.isLogged = true;
                }
            }
            return userFromDb;
        }

        public User LastLoginTimeUpdate(User user)
        {
            var userFromDb = new User();
            using (var session = NHibernateHelper.OpenSession())
            {
                userFromDb = session.Get<User>(user.Id);
                userFromDb.LastLoginDate = DateTime.Now;
            }
            return base.basePersistEntity(userFromDb);
        }

    }
}
