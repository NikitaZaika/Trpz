using DataAccessLayer.Abstract;
using DataAccessLayer.Implementation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Classes
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext context;
        private IOrderRepository orderRepository;
        private IClientRepository clientRepository;
        private ICookRepository cookRepository;
        private IDishRepository dishRepository;
        public UnitOfWork(ApplicationContext applicationContext)
        {
            context = applicationContext;
        }
        public IOrderRepository OrderRepository
        {
            get
            {
                return orderRepository ??
                    (orderRepository = new OrderRepository(context));
            }
        }
        public IClientRepository ClientRepository
        {
            get
            {
                return clientRepository ??
                    (clientRepository = new ClientRepository(context));
            }
        }
        public ICookRepository CookRepository
        {
            get
            {
                return cookRepository ??
                    (cookRepository = new CookRepository(context));
            }
        }
        public IDishRepository DishRepository
        {
            get
            {
                return dishRepository ??
                    (dishRepository = new DishRepository(context));
            }
        }
        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
