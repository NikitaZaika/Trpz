using DataAccessLayer.Abstract;
using DataAccessLayer.Implementation.Classes;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Repositories
{
    class CookRepository : Repository<CookEntity, int>, ICookRepository
    {
        public CookRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
