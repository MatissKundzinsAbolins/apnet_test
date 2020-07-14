using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppNet.DataAccess
{
    class PersonDbContext : DbContext // = Database
    { 
        public DbSet<Person> People { get; set; } // = table
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security = True;");
        }
    }
}
