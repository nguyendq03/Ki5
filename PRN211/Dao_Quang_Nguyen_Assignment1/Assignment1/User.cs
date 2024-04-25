using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string City {  get; set; }
        public int RoleID {  get; set; }


    }
}
