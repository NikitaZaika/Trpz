using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int CookID { get; set; }
        public Cook Cook { get; set; }
        public int DishID { get; set; }
        public Dish Dish { get; set; }
        public int Time { get; set; }

        public Order(int _clientID, int _cookID, int _dishID, int _time)
        {
            ClientID = _clientID;
            CookID = _cookID;
            DishID = _dishID;
            Time = _time;
        }
        public Order(int _clientID, int _cookID, int _dishID, int _time, int _id)
        {
            ClientID = _clientID;
            CookID = _cookID;
            DishID = _dishID;
            Time = _time;
            Id = _id;
        }
        public Order()
        {

        }
    }
}
