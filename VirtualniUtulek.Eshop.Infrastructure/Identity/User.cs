using System;
using Microsoft.AspNetCore.Identity;
using VirtualniUtulek.Eshop.Domain.Entities.Interfaces;

namespace VirtualniUtulek.Eshop.Infrastructure.Identity
{
    /// <summary>
    /// Our User class which can be modified
    /// </summary>
    public class User : IdentityUser<int>, IUser
    {
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
    }
}

