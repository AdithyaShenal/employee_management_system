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
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string username { get; set; }

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
