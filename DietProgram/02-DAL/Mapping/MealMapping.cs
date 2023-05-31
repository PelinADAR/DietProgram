using _01_Entity;
using _01_Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_DAL.Mapping
{
    public class MealMapping : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meal");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                     .UseIdentityColumn(1, 1)
                     .HasColumnOrder(1);

            builder.Property(a => a.Name)
                     .IsRequired()
                     .HasMaxLength(75);

            IList<Meal> meals = new List<Meal>();
            meals.Add(new Meal { ID = 1, Name = "Breakfast" });
            meals.Add(new Meal { ID = 2, Name = "Lunch" });
            meals.Add(new Meal { ID = 3, Name = "Dinner" });
            meals.Add(new Meal { ID = 4, Name = "Snack" });

            builder.HasData(meals);
        }
    }
}
