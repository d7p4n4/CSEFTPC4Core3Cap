using CSEFTPC4Core3Objects.Ac4yObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSEFTPC4Core3Cap
{
    public class Context : DbContext
    {
        public Context() : base()
        {
            //Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=89.46.75.137;Database=TPCAc4y;Trusted_Connection=False;uid=SA;pwd=Sycompla9999*;");

        }

        public DbSet<Ac4yPersistentChild> Ac4yPersistentChilds { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ac4yPersistentChild>().ToTable("Ac4yPersistentChilds");

        }
    }
}
