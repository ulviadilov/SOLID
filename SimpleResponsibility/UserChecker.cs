using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleResponsibility
{
    internal class UserChecker
    {
        public bool CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length > 20 || password.Length < 6) return false;
            return true;
        }
        public bool CheckUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 20 || username.Length < 6) return false;
            return true;
        }
    }
}
