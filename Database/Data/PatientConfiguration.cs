using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobilemedCrud.Database.Entity;

namespace MobilemedCrud.Database.Data
{
    internal class PatientConfiguration : IEntityTypeConfiguration<PatientModel>
    {
        public void Configure(EntityTypeBuilder<PatientModel> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.CPF).IsRequired();

            builder.Property(p => p.RG).IsRequired();

            builder.Property(p => p.Phone).IsRequired();

            builder.Property(p => p.Email).IsRequired();

            builder.Property(p => p.Address).IsRequired();

            builder.Property(p => p.City).IsRequired();

            builder.Property(p => p.State).IsRequired();

            builder.Property(p => p.ZipCode).IsRequired();

            builder.Property(p => p.Country).IsRequired();

            builder.Property(p => p.BloodType).IsRequired();

            builder.Property(p => p.Allergies).IsRequired();

            builder.Property(p => p.Medications).IsRequired();

            builder.Property(p => p.Notes);

            builder.Property(p => p.BirthDate).IsRequired();

        }
    }
}