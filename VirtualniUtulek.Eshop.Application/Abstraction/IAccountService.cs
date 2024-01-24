using System;
using VirtualniUtulek.Eshop.Infrastructure.Identity.Enums;
using VirtualniUtulek.Eshop.Application.ViewModels;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IAccountService
    {
        Task<string[]> Register(RegisterViewModel vm, Roles role);
        Task<bool> Login(LoginViewModel vm);
        Task Logout();
    }
}

