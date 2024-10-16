using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobilemedCrud.Database.Entity;

namespace MobilemedCrud.Database.Data
{
    internal class BookMarkConfiguration : IEntityTypeConfiguration<BookMarkModel>
    {
        public void Configure(EntityTypeBuilder<BookMarkModel> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.HasOne(p => p.Medic);

            builder.HasOne(p => p.Patient);
            
            builder.Property(p => p.Hour).IsRequired();


        }
    }
}