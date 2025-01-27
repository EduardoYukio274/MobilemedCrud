﻿using Microsoft.EntityFrameworkCore;
using MobilemedCrud.Database.Entity;
using System.Linq;

namespace MobilemedCrud.Database.Data
{
    public class AppDbContext : DbContext
    {
        // Creat the tables 

        public DbSet<BookMarkModel> BookMark { get; set; }

        public DbSet<MedicModel> Medic { get; set; }

        public DbSet<PatientModel> Patient { get; set; }

        // Conection and creat the DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string DbName = "MobilemedDB";
            string serverName = @"(LocalDb)\MSSQLLocalDB";
            string auth = "Integrated Security=SSPI";

            optionsBuilder.UseSqlServer($@"Data Source={serverName};Initial Catalog={DbName};{auth};");


            base.OnConfiguring(optionsBuilder);
        }

        // Confg the tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); modelBuilder.ApplyConfiguration<PatientModel>(new PatientConfiguration());
            base.OnModelCreating(modelBuilder); modelBuilder.ApplyConfiguration<MedicModel>(new MedicConfiguration());
            base.OnModelCreating(modelBuilder); modelBuilder.ApplyConfiguration<BookMarkModel>(new BookMarkConfiguration());
        }

        //Update the DB
        public static void UpdateDatabase()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var mg = context.Database.GetPendingMigrations();
                bool isMigrationNeeded = mg.Any();
                if (isMigrationNeeded)
                    context.Database.Migrate();
            }
        }

    }
}
