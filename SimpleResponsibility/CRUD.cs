using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleResponsibility
{
    internal class CRUD
    {
        public void Create(User user)
        {
            Database.Users.Add(user);
        }
        public void Remove(User user)
        {
            Database.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return Database.Users;
        }
    }
}
