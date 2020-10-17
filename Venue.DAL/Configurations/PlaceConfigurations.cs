using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Venue.DAL.Entities;

namespace Venue.DAL.Configurations
{
    public class PlaceConfigurations : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(y => y.Venues)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Photos)
                .WithOne(y => y.Venue)
                .HasForeignKey(y => y.VenueId);

            builder.HasMany(x => x.Comments)
                .WithOne(y => y.Venue)
                .HasForeignKey(y => y.VenueId);
        }
    }
}
