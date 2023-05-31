using _02_DAL.Mapping;
using _01_Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DAL.Context
{
    public class ProjectContext : DbContext
    {

        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<SelectedFoodTransfer> SelectedFoodTransfers { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserMealFood> UserMealFoods { get; set; }


        public int MyProperty { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             


            if (!optionsBuilder.IsConfigured)
            {

                object value = optionsBuilder.UseSqlServer("Server=.;Database=HS8_Fitology;Trusted_Connection=True;Encrypt=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodMapping());
            modelBuilder.ApplyConfiguration(new MealMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new FoodCategoryMapping());
            modelBuilder.ApplyConfiguration(new UserMealFoodMapping());



            base.OnModelCreating(modelBuilder);
        }
    }
}
