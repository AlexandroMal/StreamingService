using StreamingService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Interfaces
{
    public interface IStreamPostRepository : IBaseRepository<StreamPost>
    {
        public Task<StreamPost> GetStreamByUserIdAsync(Guid Userid);
        public Task<ICollection<StreamPost>> GetAllStreamByUserIdAsync(Guid Userid);
        public Task<StreamPost> GetStreamWithVideoByIdAsync(Guid id);

    }
}
