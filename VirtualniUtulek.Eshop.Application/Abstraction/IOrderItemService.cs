using System;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IOrderItemService
    {
        IList<OrderItem> Select();
        void Create(OrderItem orderItem);
    }
}

