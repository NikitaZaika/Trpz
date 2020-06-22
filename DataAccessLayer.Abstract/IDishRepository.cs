using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IDishRepository : IRepository<DishEntity, int>
    {
    }
}
