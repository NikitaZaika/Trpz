using BusinessLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ.User_Interface
{
    class Model : IModel
    {
        IStorageNetwork storageNetwork;
        public Model(IStorageNetwork storageNetwork)
        {
            this.storageNetwork = storageNetwork;
        }
        public List<string> GetDishes()
        {
            return storageNetwork.GetDishes();
        }
        public List<string> GetClients()
        {
            return storageNetwork.GetClients();
        }

        public void CreateOrder(string _dish, string _cook)
        {
            storageNetwork.CreateOrder(_dish, _cook);
        }
        public List<string> GetOrders()
        {
            return storageNetwork.GetOrders();
        }

    }
}
