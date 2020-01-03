using blogApi.DTOS.ReadDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Services
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> AuthenticateUserAsync(string email, string password);
        Task<AuthenticationResult> RegisterAsync(string email, string password);

        Task<bool> FindUserAsync(string email, string password);
    }
}
