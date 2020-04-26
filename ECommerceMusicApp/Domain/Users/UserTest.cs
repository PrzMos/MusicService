using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.Users
{
    public class UserTest
    {
        private readonly Guid Id = new Guid();
        
        [Fact]
        public void GivenId_ReturnTrue()
        {
            User user = new User();

            user.Id = Id;

            Assert.Equal(Id, user.Id);
        }
    }
}
