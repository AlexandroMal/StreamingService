using StreamingService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public Task<User> GetUserByCredentialsAsync(string name, string password);
        public Task<User> GetUserByEmailCredentialsAsync(string email, string password);
    }
}
