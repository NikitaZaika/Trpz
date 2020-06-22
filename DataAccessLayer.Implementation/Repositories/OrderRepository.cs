using DataAccessLayer.Implementation.Classes;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Implementation.Repositories
{
    class OrderRepository:Repository<OrderEntity, int >, IOrderRepository
    {
        public OrderRepository(ApplicationContext context) : base(context)
        {
        }
        
    }
}
