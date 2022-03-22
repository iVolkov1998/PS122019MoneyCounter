using Rubic.BusinessLogic.Blo;
using Rubic.DbContext;
using Rubic.Kedrov;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IContext _context;

        public UserService(IContext context)
        {
            _context = context;
        }

        public async Task<UserInfoBLo> AuthWithEmail(string email, string password)
        {
            User user = await _context.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);

            if (user == null) throw new NotFoundException($"Пользователь с почтой {email} не найден");

            return await ConvertToUserInformationAsync(user);
        }
    }
}
