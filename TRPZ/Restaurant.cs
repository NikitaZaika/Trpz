using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    class Restaurant
    {
        private List<Cook> cooks = new List<Cook>(); 
        private List<Order> orders = new List<Order>();
        private List<Dish> dishes = new List<Dish>();
        private List<Furnace> furnaces = new List<Furnace>();
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public List<Furnace> Furnaces
        {
            get { return furnaces; }
            set { furnaces = value; }
        }
        public List<Dish> Dishes
        {
            get { return dishes; }
            set { dishes = value; }
        }
        public List<Cook> Cooks
        {
            get { return cooks; }
            set { cooks = value; }
        }
        public void CreateOrder()
        {
        }
        public void ChooseRightCook()
        {

        }
        public void ChooseRightFurnace()
        {

        }
        public void AddDish(string name, int time, int height, string ingrid)
        {
            dishes.Add(new Dish(name, time, height, ingrid));
        }
        public void AddCook(string name, int speed)
        {
            cooks.Add(new Cook(name, speed));
        }
    }
}
