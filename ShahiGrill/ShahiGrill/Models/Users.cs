using System;
using System.Collections.Generic;
using System.Text;

namespace ShahiGrill.Models
{
    public class Users
    {
   
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Users() { }
        public Users(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {

            if (this.Username.Equals("shahi") && this.Password.Equals("grill"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
