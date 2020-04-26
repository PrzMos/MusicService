using Domain.Adresses;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance
{
    public static class ModelBuilderExtentions
    {
        private static List<Adress> Adresses = new List<Adress>()
        {
            new Adress(){Id = new Guid(), City="Kraków",Region="Małopolska", Street="Kazimierza Wielkiego", BuildingNumber=4,HouseNumber=13}
        };
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreateAdress(modelBuilder);
            CreateUsers(modelBuilder);
        }
        private static void CreateUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = new Guid(), FirstName = "Josh", LastName = "Corney", AdressId = Adresses.FirstOrDefault().Id, Email = @"jCorney2@gmail.com" }); ;



        }

        private static void CreateAdress(ModelBuilder modelBuilder)
        {
            Adresses.Add(new Adress() { });
        }
    }
}
