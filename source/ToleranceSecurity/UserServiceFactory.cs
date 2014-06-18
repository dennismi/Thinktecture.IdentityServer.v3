using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Services;
namespace ToleranceSecurity
{
    public class UserServiceFactory
    {
        public static IUserService Factory()
        {
            var userAccountRepo = new UserAccountRepository();
            var accountService = new UserAccountService(userAccountRepo);
            var userService = new UserService(accountService, userAccountRepo);
            return userService;
        }

        
        static UserServiceFactory()
        {
        
        }
    }
}
