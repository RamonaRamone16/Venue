using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Venue.DAL.Entities;

namespace Venue.DAL.Configurations
{
    public class PhotoConfigurations : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(y => y.Photos)
                .HasForeignKey(x => x.UserId)
                .IsRequired(false);

            builder.HasOne(x => x.Venue)
                .WithMany(y => y.Photos)
                .HasForeignKey(x => x.VenueId)
                .IsRequired(false);
        }
    }
}
