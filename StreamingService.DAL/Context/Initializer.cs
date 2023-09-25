using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Context
{
    public class Initializer
    {
        public static void Initialize(StreamingDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
