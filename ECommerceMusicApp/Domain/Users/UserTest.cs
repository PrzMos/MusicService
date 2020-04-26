using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.Users
{
    public class UserTest
    {
        private readonly Guid Id = new Guid();
        private readonly string FirstName = "John";
        private readonly string LastName = "Wallet";
        private readonly Guid AdressId = new Guid();
        private readonly string Email = "jwallet@gmail.com";
        private readonly string Password = "password123";
        
        [Fact]
        public void GivenId_ReturnTrue()
        {
            User user = new User();

            user.Id = Id;

            Assert.Equal(Id, user.Id);
        }

        [Fact]
        public void GivenFirstName_ReturnTrue()
        {
            User user = new User();

            user.FirstName = FirstName;

            Assert.Equal(FirstName, user.FirstName);
        }

        [Fact]
        public void GivenLastName_ReturnTrue()
        {
            User user = new User();

            user.LastName = LastName;

            Assert.Equal(LastName, user.LastName);
        }

        [Fact]
        public void GivenAdressId_ReturnTrue()
        {
            User user = new User();

            user.AdressId = AdressId;

            Assert.Equal(AdressId, user.AdressId);
        }

        [Fact]
        public void GivenEmail_ReturnTrue()
        {
            User user = new User();

            user.Email = Email;

            Assert.Equal(Email, user.Email);
        }

        [Fact]
        public void GivenPassword_ReturnTrue()
        {
            User user = new User();

            user.Password = Password;

            Assert.Equal(Password, user.Password);
        }

        //To do Password Hasher
    }
}
