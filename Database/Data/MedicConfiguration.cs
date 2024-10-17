using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobilemedCrud.Database.Entity;

namespace MobilemedCrud.Database.Data
{
    internal class MedicConfiguration : IEntityTypeConfiguration<MedicModel>
    {
        public void Configure(EntityTypeBuilder<MedicModel> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.CPF).IsRequired();

            builder.Property(p => p.RG).IsRequired();

            builder.Property(p => p.Phone).IsRequired();

            builder.Property(p => p.Email).IsRequired();

            builder.Property(p => p.Address).IsRequired();

            builder.Property(p => p.State).IsRequired();

            builder.Property(p => p.ZipCode).IsRequired();

            builder.Property(p => p.Country).IsRequired();

            builder.Property(p => p.CRM).IsRequired();

            builder.Property(p => p.BirthDate).IsRequired();

        }
    }
}