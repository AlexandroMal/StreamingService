using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Entities
{
    public class StreamPost : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ConnectInfo { get; set; }
        public bool StreamStatus { get; set; }

        public Guid CreatedForUser { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Video>? Videos { get; set; }


    }
}
