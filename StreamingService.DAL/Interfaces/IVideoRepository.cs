using StreamingService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Interfaces
{
    public interface IVideoRepository : IBaseRepository<Video>
    {
        public Task<Video> GetVideoByStreamPostIdAsync(Guid StreamId);
        public Task<ICollection<Video>> GetVideosByStreamPostIdAsync(Guid StreamId);

    }
}
