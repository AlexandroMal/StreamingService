using Microsoft.EntityFrameworkCore;
using StreamingService.DAL.Entities;
using StreamingService.DAL.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Context
{
    public class StreamingDbContext : DbContext
    {
        public StreamingDbContext(DbContextOptions options) 
            : base(options) { }

        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VideoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
