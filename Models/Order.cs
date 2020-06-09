using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Order
    {
        public int Id { get; set; }
        
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int CookID { get; set; }
        public Cook Cook { get; set; }
        public int DishID { get; set; }
        public Dish Dish { get; set; }

        public Order(int _clientID, int _cookID, int _dishID)
        {
            ClientID = _clientID;
            CookID = _cookID;
            DishID = _dishID;
        }
        public Order()
        {

        }
    }
}
