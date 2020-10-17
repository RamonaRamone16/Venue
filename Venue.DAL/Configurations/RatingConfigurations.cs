using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Venue.DAL.Entities;

namespace Venue.DAL.Configurations
{
    public class RatingConfigurations : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(y => y.Ratings)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Place)
                .WithMany(y => y.Ratings)
                .HasForeignKey(x => x.PlaceId);
        }
    }
}
