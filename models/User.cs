using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_management_system.models
{
    internal class User
    {
        public string name { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }
        public string username { get; private set; }

        public User(string name, string password, string email, string username) {
            this.name = name;
            this.email = email;
            this.password = password;
            this.username = username;
        }

        public bool validatePassword(string password) {
            // Should use RegEx
            if (String.IsNullOrEmpty(password) || password.Length < 3) {
                return false;
            }
            return true;
        }
    }
}
