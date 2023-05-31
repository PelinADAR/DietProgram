using _01_Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_DAL.Mapping
{
    public class FoodMapping : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Food");

            builder.HasKey(x => x.ID);

            builder.Property(X => X.ID)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1);

            builder.Property(a => a.Name)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(75)
                    .HasColumnOrder(2);

            builder.Property(a => a.Calory)
                   .HasColumnOrder(3);

            //builder.Property(a => a.FoodTypes)
            //       .HasColumnOrder(4);

            builder.Property(a => a.Portion)
                   .HasColumnOrder(5);



            //Navigation:
            builder.HasOne(a => a.FoodCategory)
                .WithMany(a => a.Foods)
                .HasForeignKey(a => a.FoodCategoryID);



            IList<Food> foods = new List<Food>();
            foods.Add(new Food { ID = 1, Name = "Ribeye", Portion = 1, Calory = 250, FoodCategoryID = 1 });
            foods.Add(new Food { ID = 2, Name = "Tendeloin", Portion = 1, Calory = 223, FoodCategoryID = 1 });
            foods.Add(new Food { ID = 3, Name = "Chicken", Portion = 1, Calory = 252, FoodCategoryID = 1 });
            foods.Add(new Food { ID = 4, Name = "Trout", Portion = 1, Calory = 170, FoodCategoryID = 2 });
            foods.Add(new Food { ID = 5, Name = "Anchovy", Portion = 1, Calory = 150, FoodCategoryID = 2 });
            foods.Add(new Food { ID = 6, Name = "Cheddar Cheese ", Portion = 1, Calory = 400, FoodCategoryID = 3 });
            foods.Add(new Food { ID = 7, Name = "Hellim Cheese", Portion = 1, Calory = 360, FoodCategoryID = 3 });
            foods.Add(new Food { ID = 8, Name = "Tomatoes", Portion = 1, Calory = 42, FoodCategoryID = 5 });
            foods.Add(new Food { ID = 9, Name = "Carrot", Portion = 1, Calory = 42, FoodCategoryID = 5 });
            foods.Add(new Food { ID = 10, Name = "Apple", Portion = 1, Calory = 58, FoodCategoryID = 4 });
            foods.Add(new Food { ID = 11, Name = "Plum", Portion = 1, Calory = 75, FoodCategoryID = 4 });
            foods.Add(new Food { ID = 12, Name = "Mashed Potatoes", Portion = 1, Calory = 83, FoodCategoryID = 9 });
            foods.Add(new Food { ID = 13, Name = "Rice Pilaf", Portion = 1, Calory = 185, FoodCategoryID = 9 });
            foods.Add(new Food { ID = 14, Name = "White Bread", Portion = 1, Calory = 69, FoodCategoryID = 6 });
            foods.Add(new Food { ID = 15, Name = "Brown Bread", Portion = 1, Calory = 63, FoodCategoryID = 6 });
            foods.Add(new Food { ID = 16, Name = "Pogaca", Portion = 1, Calory = 225, FoodCategoryID = 6 });
            foods.Add(new Food { ID = 17, Name = "Avacado", Portion = 1, Calory = 167, FoodCategoryID = 5 });
            foods.Add(new Food { ID = 18, Name = "Pasta", Portion = 1, Calory = 307, FoodCategoryID = 6 });
            foods.Add(new Food { ID = 19, Name = "Ice Cream", Portion = 1, Calory = 193, FoodCategoryID = 7 });
            foods.Add(new Food { ID = 20, Name = "Chocolate Cake", Portion = 1, Calory = 431, FoodCategoryID = 7 });
            foods.Add(new Food { ID = 21, Name = "Water", Portion = 1, Calory = 0, FoodCategoryID = 8 });
            foods.Add(new Food { ID = 22, Name = "Cola", Portion = 1, Calory = 122, FoodCategoryID = 8 });
            foods.Add(new Food { ID = 23, Name = "Milk", Portion = 1, Calory = 84, FoodCategoryID = 8 });
            foods.Add(new Food { ID = 24, Name = "Olive", Portion = 1, Calory = 115, FoodCategoryID = 4 });
            foods.Add(new Food { ID = 25, Name = "Milk Chocolate", Portion = 1, Calory = 545, FoodCategoryID = 10 });
            foods.Add(new Food { ID = 26, Name = "Cips", Portion = 1, Calory = 536, FoodCategoryID = 10 });
            builder.HasData(foods);
        }
    }
}
