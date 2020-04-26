using Domain.Adresses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Guid AdressId { get; set; }
        public Adress Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User()
        {
            Username = GenerateUsername();
        }

        private string GenerateUsername()
        {
            Random random = new Random();
            return $"{FirstName.Substring(3)}{random.Next(0,9)}{LastName.Substring(4)}";
        }
    }
}
