using System;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IOrderService
    {
        IList<Order> Select();
    }
}

