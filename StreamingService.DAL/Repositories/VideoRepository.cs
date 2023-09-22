using StreamingService.DAL.Context;
using StreamingService.DAL.Entities;
using StreamingService.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Repositories
{
    public class VideoRepository : BaseRepository<Video>, IVideoRepository
    {
        public VideoRepository(StreamingDbContext dbContext) : base(dbContext)
        {

        }
    }
}
