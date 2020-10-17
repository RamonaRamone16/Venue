using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Venue.DAL.Entities;

namespace Venue.DAL.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(x => x.Comments)
                .WithOne(y => y.User)
                .HasForeignKey(y => y.UserId);

            builder.HasMany(x => x.Venues)
                .WithOne(y => y.User)
                .HasForeignKey(y => y.UserId);

            builder.HasMany(x => x.Photos)
                .WithOne(y => y.User)
                .HasForeignKey(y => y.UserId);
        }
    }
}
