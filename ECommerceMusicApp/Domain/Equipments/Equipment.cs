using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Equipments
{
    public class Equipment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public long Quantity { get; set; }
        public double Price { get; set; }
    }
}
