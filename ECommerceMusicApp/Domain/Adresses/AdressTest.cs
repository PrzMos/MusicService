using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace Domain.Adresses
{
    public class AdressTest
    {
        private readonly Guid Id = new Guid();
        private readonly string _city = "Kraków";
        private readonly string _street = "Olszewskiej";
        private readonly int _buildingNumber = 4;
        private readonly int _houseNumber;

        [Fact]
        public void GivenId_Should_ReturnTrue()
        {
            Adress adress = new Adress();

            adress.Id = Id;

            Assert.Equal(Id, adress.Id);
        }

        [Fact]
        public void GivenCity_Should_ReturnTrue()
        {
            Adress adress = new Adress();

            adress.City = _city;

            Assert.Equal(_city, adress.City);
        }

        [Fact]
        public void GivenStreet_Should_ReturnTrue()
        {
            Adress adress = new Adress();

            adress.Street = _street;

            Assert.Equal(_street, adress.Street);
        }

        [Fact]
        public void GivenBuildingNumber_Should_ReturnTrue()
        {
            Adress adress = new Adress();

            adress.BuildingNumber = _buildingNumber;

            Assert.Equal(_buildingNumber, adress.BuildingNumber);
        }

        [Fact]
        public void GivenNull_Should_ReturnFalse()
        {
            Adress adress = new Adress();

            adress.HouseNumber = _houseNumber;

            Assert.Equal(_houseNumber, adress.BuildingNumber);
        }
    }
}
