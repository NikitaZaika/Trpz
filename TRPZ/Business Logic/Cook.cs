using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    class Cook
    {
        private string name_of_cook;
        private int speed_of_cook;
        private List<Order> orders_for_cook = new List<Order>();

        public Cook(string name, int speed)
        {
            name_of_cook = name;
            speed_of_cook = speed;
        }
        public string Name_of_cook
        { get { return name_of_cook; } set { name_of_cook = value; } }
        public int Speed_of_cook
        { get { return speed_of_cook; } set { speed_of_cook = value; } }
        public List<Order> Orders_of_cook
        {
            get { return orders_for_cook; }
            set { orders_for_cook = value; }
        }
        public void AddOrdersForCook()
        {
        }
    }
}
