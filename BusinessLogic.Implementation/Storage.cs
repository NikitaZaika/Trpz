using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.IO;

namespace BusinessLogic.Implementation
{
    public static class Storage
    {
        public static List<Client> clients { get; set; } = new List<Client>();
        public static List<Cook> cooks { get; set; } = new List<Cook>();
        public static List<Dish> dishes { get; set; } = new List<Dish>();
        public static List<Order> orders { get; set; } = new List<Order>();

        public static List<Client> Clients
        {
            get { return clients; }
            set { clients = value; }
        }
        public static List<Cook> Cooks
        {
            get { return cooks; }
            set { cooks = value; }
        }
        public static List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public static List<Dish> Dishes
        {
            get { return dishes; }
            set { dishes = value; }
        }

        public static void AddClient(string _name, int _id)
        {
            clients.Add(new Client(_name, _id));
        }
        public static void AddCook(string _name, string _type, int _id)
        {
            cooks.Add(new Cook(_name, _type, _id));
        }
        public static void AddDish(string _name, int _cost, int _time, int _id)
        {
            dishes.Add(new Dish(_name, _cost, _time, _id));
        }
        public static void AddOrder(int _clientID, int _cookID, int _dishID, int _time, int _id)
        {
            orders.Add(new Order(_clientID, _cookID, _dishID, _time, _id));
        }

        public static void CreateOrder()
        {
        }
        public static void ChooseRightCook()
        {

        }
    }
}
