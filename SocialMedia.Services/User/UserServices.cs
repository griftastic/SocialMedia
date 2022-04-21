using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services.User
{
    public class UserServices : IUserService
    {
        public async Task<UserDetail> GetUserDetailAsync(int userId)
        {
            var entity = await _contex.Users.FindAsync(userId);
            if (entity is null)
                return null;

            var UserDetail = new UserDetail
            {
                Id = entity.Id,
                Email = entity.Email,
                Username = entity.Username,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DatedCreated = entity.DatedCreated
            };
            
                return UserDetail;
        }
    }
}