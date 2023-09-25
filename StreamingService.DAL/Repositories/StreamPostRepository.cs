using StreamingService.DAL.Context;
using StreamingService.DAL.Entities;
using StreamingService.DAL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Repositories
{
    public class StreamPostRepository : BaseRepository<StreamPost>, IStreamPostRepository
    {
        public StreamPostRepository(StreamingDbContext dbContext) : base(dbContext)
        {

        }


        public async Task<StreamPost> GetStreamByUserIdAsync(Guid Userid)
        {
            var result = await _dbContext.Streams.FirstOrDefaultAsync(x => x.CreatedForUser == Userid);
            return result;
        }

        public async Task<ICollection<StreamPost>> GetAllStreamByUserIdAsync(Guid Userid)
        {
            var result = await _dbContext.Streams
                .Where(x => x.CreatedForUser == Userid)
                .ToListAsync();

            return result;
        }

        public async Task<StreamPost> GetStreamWithVideoByIdAsync(Guid id)
        {
            var result = await _dbContext.Streams
                .Include(x => x.Videos)
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }
    }
}
