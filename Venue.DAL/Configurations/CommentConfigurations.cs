using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Venue.DAL.Entities;

namespace Venue.DAL.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(y => y.Comments)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Venue)
                .WithMany(y => y.Comments)
                .HasForeignKey(x => x.VenueId);
        }
    }
}
