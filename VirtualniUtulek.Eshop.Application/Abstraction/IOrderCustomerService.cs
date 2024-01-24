using System;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IOrderCustomerService
    {
        IList<Order> GetOrdersForUser(int userId);
    }
}

