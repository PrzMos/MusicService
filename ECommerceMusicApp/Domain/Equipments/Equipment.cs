using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Equipments
{
    public class Equipment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public Guid CompanyId { get; set; }
        [Required]
        [Range(0, 10000)]
        public long Quantity { get; set; }
        [Required]
        [Range(0,100000)]
        public double Price { get; set; }
    }
}
