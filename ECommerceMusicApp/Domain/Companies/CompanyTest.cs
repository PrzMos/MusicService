using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.Companies
{
    public class CompanyTest
    {
        private readonly Guid Id = new Guid();
        private readonly String Name = "Janusz";
        private readonly CompanyTypes CompanyType = CompanyTypes.SpZoo;

        [Fact]
        public void GivenId_ShouldReturnTrue()
        {
            Company company = new Company();

            company.Id = Id;

            Assert.Equal(Id, company.Id);
        }

        [Fact]
        public void GivenName_ShouldReturnTrue()
        {
            Company company = new Company();

            company.Name = Name;

            Assert.Equal(Name, company.Name);
        }

        [Fact]
        public void GivenCompanyType_ShouldReturnTrue()
        {
            Company company = new Company();

            company.CompanyType = CompanyType;

            Assert.Equal(CompanyType, company.CompanyType);
        }
    }
}
