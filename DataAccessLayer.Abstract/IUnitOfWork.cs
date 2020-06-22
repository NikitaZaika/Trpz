using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        public IOrderRepository OrderRepository { get; }
        public IDishRepository DishRepository { get; }
        public ICookRepository CookRepository { get; }
        public IClientRepository ClientRepository { get; }
    }
}
