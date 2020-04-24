using Domain.Adresses;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance
{
    public class ServiceDbContext : DbContext 
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        {
            SeedTables();
        }
        DbSet<User> Users { get; set; }
        DbSet<Adress> Adresses { get; set; }

        private void SeedTables()
        {
            CreateUser();
            CreateAdress();
        }

        private void CreateUser()
        {
            Users.Add(new User() { Id = new Guid(), FirstName = "Josh", LastName = "Corney", AdressId = new Guid(), Email = @"jCorney2@gmail.com" });
        }

        private void CreateAdress()
        {
            
        }

        private void Save()
        {
            this.SaveChanges();
        }
    }
}
