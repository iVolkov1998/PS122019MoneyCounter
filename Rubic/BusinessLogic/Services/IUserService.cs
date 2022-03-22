using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.BusinessLogic.Services
{
    interface IUserService
    {
        Task<UserInfoBLo> Register(string phoneNumberPrefix, string phoneNumber, string password);

        Task<UserInfoBLo> Get(int userId);

        Task<UserInfoBLo> UpdateWithPhone(string phoneNumberPrefix, string phoneNumber, string password, UserUpdateBlo userUpdateBlo);
        Task<UserInfoBLo> UpdateWithMail(string mail, string password, UserUpdateBlo userUpdateBlo);

        Task<UserInfoBLo> Authenticate(string numberPrefix, string phoneNumber, string password);

        Task<bool> DoesUserExist(string phoneNumberPrefix, string phoneNumber);

        Task<string> GetUserPassword(string numberPrefix, string phoneNumber);
    }
}
