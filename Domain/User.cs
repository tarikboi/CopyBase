using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBase.Domain
{
    internal class User
    {
        public static string fullName { get; set; }
        public static string username { get; set; }
        public static string email { get; set; }

        public User(string fullName, string username,string email)
        {
            User.fullName = fullName;
            User.username = username;
            User.email = email;
        }
    }
}
