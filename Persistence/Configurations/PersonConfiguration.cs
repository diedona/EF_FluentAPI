using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);

        builder.OwnsOne(x => x.Email)
            .Property(x => x.Address)
                .HasMaxLength(250)
                .IsRequired();

        builder.Property(x => x.Name)
            .HasMaxLength(420);
    }
}
