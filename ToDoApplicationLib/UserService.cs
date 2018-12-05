using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplicationLib.EntityModel;

namespace ToDoApplicationLib
{
    public class UserService
    {
        private DbContext dbConnection;

        public UserService(DbContext ctx)
        {
            this.dbConnection = ctx;
        }
        
        public List<Users> getAllLogin()
        {
            return dbConnection.Users.ToList<Users>();
            
        }
    }
}
