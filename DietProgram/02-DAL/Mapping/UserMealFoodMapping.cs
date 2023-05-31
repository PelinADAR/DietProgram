using _01_Entity;
using _01_Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_DAL.Mapping
{
    public class UserMealFoodMapping : IEntityTypeConfiguration<UserMealFood>
    {
        public void Configure(EntityTypeBuilder<UserMealFood> builder)
        {
            builder.ToTable("UserMealFood");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .UseIdentityColumn(1, 1)
                 .HasColumnOrder(1);

            builder.Property(a => a.CreatedDate)
                    .HasDefaultValueSql("GetDate()");

            builder.Property(a => a.Portion);


            //Navigation:
            builder.HasOne(a => a.User)
                  .WithMany(a => a.UserMealFoods)
                   .HasForeignKey(a => a.UserID);

            builder.HasOne(a => a.Food)
                    .WithMany(a => a.UserMealFoods)
                   .HasForeignKey(a => a.FoodID);

            builder.HasOne(a => a.Meal)
                  .WithMany(a => a.UserMealFoods)
                  .HasForeignKey(a => a.MealID);


        }
    }

}
