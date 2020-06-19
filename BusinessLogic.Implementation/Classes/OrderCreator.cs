using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implementation.Classes
{
    public class OrderCreator
    {
        public void CreateOrder(Dish _dish, Client _client)
        {
            Cook correct_cook = ChooseCorrectCook();
            Storage.AddOrder(_client.Id, correct_cook.Id, _dish.Id, _dish.Time, Storage.Orders.Count+1);
        }

        public Cook ChooseCorrectCook()
        {

            Cook correct_cook = Storage.Cooks[0];
            foreach (Cook c in Storage.Cooks)
            {
                if (c.CountOfOrders < correct_cook.CountOfOrders)
                {
                    correct_cook = c;
                }
            }
            return correct_cook;
        }
    }
}
