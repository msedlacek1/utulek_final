using System;
using Microsoft.EntityFrameworkCore;
using VirtualniUtulek.Eshop.Domain.Entities;
using VirtualniUtulek.Eshop.Infrastructure.Database;
using VirtualniUtulek.Eshop.Application.Abstraction;

namespace VirtualniUtulek.Eshop.Application.Implementation
{
    public class OrderCustomerService : IOrderCustomerService
    {
        EshopDbContext _eshopDbContext;

        public OrderCustomerService(EshopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        public IList<Order> GetOrdersForUser(int userId)
        {
            return _eshopDbContext.Orders.Where(or => or.UserId == userId)
                                         .Include(o => o.User)
                                         .Include(o => o.OrderItems)
                                         .ThenInclude(oi => oi.Zvire)
                                         .ToList();
        }
    }
}

