using _01_Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_DAL.Mapping
{
    public class FoodCategoryMapping : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.ToTable("FoodCategory");

            builder.HasKey(x => x.ID);

            builder.Property(X => X.ID)
                .UseIdentityColumn(1,1)    
                .HasColumnOrder(1);

            builder.Property(a => a.Name)
                   .HasColumnOrder(2)
                   .HasMaxLength(75);

            IList<FoodCategory> foodCategories = new List<FoodCategory>();
            foodCategories.Add(new FoodCategory { ID = 1, Name = "Meat Product" });
            foodCategories.Add(new FoodCategory { ID = 2, Name = "Sea Product" });
            foodCategories.Add(new FoodCategory { ID = 3, Name = "Milk Product" });
            foodCategories.Add(new FoodCategory { ID = 4, Name = "Fruit" });
            foodCategories.Add(new FoodCategory { ID = 5, Name = "VegeTable" });
            foodCategories.Add(new FoodCategory { ID = 6, Name = "Pastry" });
            foodCategories.Add(new FoodCategory { ID = 7, Name = "Dessert" });
            foodCategories.Add(new FoodCategory { ID = 8, Name = "Drink" });
            foodCategories.Add(new FoodCategory { ID = 9, Name = "Homemade Food" });
            foodCategories.Add(new FoodCategory { ID = 10, Name = "Snack" });

            builder.HasData(foodCategories);
        }
    }
}
