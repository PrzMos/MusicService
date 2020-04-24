using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Companies
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CompanyTypes CompanyType { get; set; }
    }
}
