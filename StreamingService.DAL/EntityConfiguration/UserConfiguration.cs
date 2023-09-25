using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreamingService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(125);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);

            builder
                .HasMany(x => x.StreamPosts)
                .WithOne(x => x.User)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CreatedForUser);
        }
    }
}
