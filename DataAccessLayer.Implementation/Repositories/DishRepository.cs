using DataAccessLayer.Abstract;
using DataAccessLayer.Implementation.Classes;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Repositories
{
    class DishRepository : Repository<DishEntity, int>, IDishRepository
    {
        public DishRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
