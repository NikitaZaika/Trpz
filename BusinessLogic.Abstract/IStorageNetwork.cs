using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstract
{
    public interface IStorageNetwork
    {
        List<string> GetDishes();
        List<string> GetClients();
        void CreateOrder(string dish, string cook);
        List<string> GetOrders();
    }
}
