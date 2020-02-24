using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    class Order
    {
        private Dish dish_order;
        private int order_time;
        private Cook order_cook;

        public Order(Dish dish)
        {
            dish_order = dish;
        }
        public Dish Dish_order
        {
            get { return dish_order; }
            set { dish_order = value; }
        }
        public int Order_time
        {
            get { return order_time; }
            set { order_time = value; }
        }
        public void CalculateOrderTime()
        {
            Order_time = dish_order.Time_of_cooking * order_cook.Speed_of_cook;
        }
    }
}
