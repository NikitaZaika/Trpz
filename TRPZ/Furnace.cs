using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    class Furnace
    {
        List<Order> orders_furnace = new List<Order>();
        public List<Order> Orders_furnace
        {
            get { return orders_furnace; }
            set { orders_furnace = value; }
        }
    }
}
