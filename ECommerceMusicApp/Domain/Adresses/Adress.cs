using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Adresses
{
    public class Adress
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [Required]
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int HouseNumber { get; set; }
    }
}
