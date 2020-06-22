using DataAccessLayer.Abstract;
using DataAccessLayer.Implementation.Classes;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Repositories
{
    class ClientRepository : Repository<ClientEntity, int>, IClientRepository
    {
        public ClientRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
