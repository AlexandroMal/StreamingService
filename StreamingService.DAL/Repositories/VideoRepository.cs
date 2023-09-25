using StreamingService.DAL.Context;
using StreamingService.DAL.Entities;
using StreamingService.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<Video> GetVideoByStreamPostIdAsync(Guid StreamId)
        {
            var result = await _dbContext.Videos
                .FirstOrDefaultAsync(x => x.CreatedForStreamPost == StreamId);

            return result;
        }

        public async Task<ICollection<Video>> GetVideosByStreamPostIdAsync(Guid StreamId)
        {
            var result = await _dbContext.Videos
                .Where(x => x.CreatedForStreamPost == StreamId)
                .ToListAsync();

            return result;
        }
    }
}
