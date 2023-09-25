using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreamingService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.EntityConfiguration
{
    public class StreamPostConfiguration : IEntityTypeConfiguration<StreamPost>
    {
        public void Configure(EntityTypeBuilder<StreamPost> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ConnectInfo);
            builder.Property(x => x.StreamStatus).IsRequired().HasDefaultValue(false);

            builder
                .HasMany(x => x.Videos)
                .WithOne(x => x.StreamPost)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CreatedForStreamPost)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
