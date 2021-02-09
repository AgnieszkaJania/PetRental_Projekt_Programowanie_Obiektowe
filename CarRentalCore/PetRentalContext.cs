using Microsoft.EntityFrameworkCore;
using PetAccessoryRentalCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetAccessoryRentalCore {
    public class PetRentalContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PetRental");
        }
        public DbSet<Rental> Rentals {
            get; private set;
        }
        public DbSet<Accessory> Accessories {
            get; private set;
        }
        public DbSet<Client> Clients {
            get; private set;
        }
        public DbSet<PetType> PetTypes {
            get; private set;
        }

        public DbSet<Size> Sizes {
            get; private set;
        }
    }
}
