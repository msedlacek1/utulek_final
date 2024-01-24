using System;
using Microsoft.AspNetCore.Http;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IOrderCartService
    {
        double AddOrderItemsToSession(int? zvireId, ISession session);
        bool ApproveOrderInSession(int userId, ISession session);
    }
}

