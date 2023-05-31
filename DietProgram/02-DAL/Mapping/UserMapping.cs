using _01_Entity;
using _01_Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_DAL.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1);

            builder.Property(a => a.FirstName)
                                .HasColumnType("nvarchar")
               .HasMaxLength(30);

            builder.Property(a => a.LastName)
                                .HasColumnType("nvarchar")
              .HasMaxLength(30);

            builder.Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(a => a.Email)
                                .HasColumnType("nvarchar")
              .HasMaxLength(100);

            builder.HasIndex(a => a.Email)
                .IsUnique();

            builder.Property(a => a.BirthDate);

            builder.Property(a => a.Gender);

            builder.Property(a => a.CreatedDate)
                                .HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Weight)
                .HasColumnType("decimal");

            builder.Property(x => x.Height)
                .HasColumnType("decimal");
        }
    }
}
