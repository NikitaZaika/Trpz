using BusinessLogic.Abstract;
using BusinessLogic.Implementation.Classes;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implementation
{
    public class StorageNetwork : IStorageNetwork
    {
        OrderCreator orderCreator;
        public StorageNetwork(OrderCreator orderCreator, DataLoader dataLoader)
        {
            this.orderCreator = orderCreator;
            dataLoader.LoadData();
        }
        public List<string> GetDishes()
        {
            List<string> dishesNames = new List<string>();
            foreach (Dish dish in Storage.Dishes)
            {
                dishesNames.Add(dish.Name);
            }
            return dishesNames;
        }
        public List<string> GetClients()
        {
            List<string> clientsNames = new List<string>();
            foreach (Client client in Storage.Clients)
            {
                clientsNames.Add(client.Name);
            }
            return clientsNames;
        }
        public List<string> GetOrders()
        {
            List<string> ordersNames = new List<string>();
            foreach (Order order in Storage.Orders)
            {
                ordersNames.Add(order.Id.ToString());
            }
            return ordersNames;
        }
        public Dish GetDish(string nameOfDish)
        {
            foreach (Dish dish in Storage.Dishes)
            {
                if (nameOfDish == dish.Name)
                {
                    return dish;

                }
            }
            return null;
        }
        public Client GetClient(string nameOfClient)
        {
            foreach (Client client in Storage.Clients)
            {
                if (nameOfClient == client.Name)
                {
                    return client;

                }
            }
            return null;
        }
        public void CreateOrder(string dish, string client)
        {
            orderCreator.CreateOrder( GetDish(dish), GetClient(client));
        }
    }
}
