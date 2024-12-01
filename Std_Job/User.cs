using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std_Job
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin" or "Student"
        public List<string> Skills { get; set; }  // Add skills list
        public string FullName { get; set; }      // Add a name or ID for the user

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
            Skills = new List<string>();  // Initialize an empty list of skills
        }
    }
}

