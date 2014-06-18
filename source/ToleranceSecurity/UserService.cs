using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Services;

namespace ToleranceSecurity
{
    public class UserService: IUserService, IDisposable
    {
        public UserService(UserAccountService userAccountService, IDisposable cleanup)
        {
            this.userAccountService = userAccountService;
            this.cleanup = cleanup;


        }
        private IDisposable cleanup;
        private UserAccountService userAccountService;
        public Task<Thinktecture.IdentityServer.Core.Authentication.AuthenticateResult> AuthenticateLocalAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Thinktecture.IdentityServer.Core.Authentication.ExternalAuthenticateResult> AuthenticateExternalAsync(string subject, Thinktecture.IdentityServer.Core.Models.ExternalIdentity externalUser)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<System.Security.Claims.Claim>> GetProfileDataAsync(string subject, IEnumerable<string> requestedClaimTypes = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsActive(string subject)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (this.cleanup != null)
            {
                this.cleanup.Dispose();
                this.cleanup = null;
            }
        }
    }
}
