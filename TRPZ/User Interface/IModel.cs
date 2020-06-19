using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ.User_Interface
{
    interface IModel
    {
        public List<string> GetDishes();
        public List<string> GetClients();
        public void CreateOrder(string _dish, string _cook);
        public List<string> GetOrders();
    }
}
