using CSARMetaPlan.Class;
using CSEFTPC4Core3Objects.Ac4yObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSEFTPC4Core3Cap
{
    public class Context : DbContext
    {
        private IConfiguration Configuration;

        public Context() : base()
        {

            Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MyConnection"));

        }

        public DbSet<Ac4yPersistentChild> Ac4yPersistentChilds { get; set; }
        public DbSet<Kepernyo> Kepernyos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ac4yPersistentChild>().ToTable("Ac4yPersistentChilds");

            //modelBuilder.Entity<Ac4yPersistentChild>().HasNoKey();
        }
    }
}
