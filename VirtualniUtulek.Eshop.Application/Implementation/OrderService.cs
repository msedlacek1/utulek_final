using System;
using Microsoft.EntityFrameworkCore;
using VirtualniUtulek.Eshop.Domain.Entities;
using VirtualniUtulek.Eshop.Infrastructure.Database;
using VirtualniUtulek.Eshop.Application.Abstraction;

namespace VirtualniUtulek.Eshop.Application.Implementation
{
    public class OrderService : IOrderService
    {
        EshopDbContext _eshopDbContext;

        public OrderService(EshopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        public IList<Order> Select()
        {
            return _eshopDbContext.Orders
                                  .Include(oi => oi.User)
                                  .ToList();
        }
    }
}

