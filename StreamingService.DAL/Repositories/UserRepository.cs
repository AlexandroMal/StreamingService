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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(StreamingDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> GetUserByCredentialsAsync(string name, string password)
        {
            var result = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.UserName == name && x.Password == password);

            return result;
        }

        public async Task<User> GetUserByEmailCredentialsAsync(string email, string password)
        {
            var result = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.Email == email && x.Password == password);

            return result;
        }
    }
}
