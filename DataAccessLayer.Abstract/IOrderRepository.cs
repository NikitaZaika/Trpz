﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract 
{
    public interface IOrderRepository:IRepository<OrderEntity, int>
    {
    }
}
