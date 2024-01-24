using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VirtualniUtulek.Eshop.Infrastructure.Identity;
using VirtualniUtulek.Eshop.Infrastructure.Identity.Enums;
using VirtualniUtulek.Eshop.Application.ViewModels;
using VirtualniUtulek.Eshop.Application.Abstraction;

namespace VirtualniUtulek.Eshop.Application.Implementation
{
    public class SecurityIdentityService : ISecurityService
    {
        UserManager<User> userManager;

        public SecurityIdentityService(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public Task<User> FindUserByEmail(string email)
        {
            return userManager.FindByEmailAsync(email);
        }

        public Task<User> FindUserByUsername(string username)
        {
            return userManager.FindByNameAsync(username);
        }

        public Task<User> GetCurrentUser(ClaimsPrincipal principal)
        {
            return userManager.GetUserAsync(principal);
        }

        public Task<IList<string>> GetUserRoles(User user)
        {
            return userManager.GetRolesAsync(user);
        }
    }
}
