using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;

namespace ToDoApplicationLib.EntityModel
{

    public class User
    {
        public User(String login, String name, String pass)
        {
            Login = login;
            FullName = name;
            Password = pass;
            Tasks = new List<Task>();
        }
        public User()
        {
            Tasks = new List<Task>();
        }

        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string FullName { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime? LastLoginDate { get; set; }
        public virtual bool isLogged { get; set; }

        public virtual IList<Task> Tasks { get; set; }

        public class UserMap : ClassMap<User>
        {
            public UserMap()
            {
                Id(x => x.Id);
                Map(x => x.Login);
                Map(x => x.FullName);
                Map(x => x.Password);
                Map(x => x.LastLoginDate);
                HasMany(x => x.Tasks)
                    .KeyColumn("User_Id")
                    .Inverse();
                Table("[User]");
            }
        }
    }
}
