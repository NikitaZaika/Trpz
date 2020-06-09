using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class OrderEntity : IEntity<int>
    {
        public int Id { get; set; }

        public int ClientID { get; set; }
        public ClientEntity Client { get; set; }
        public int CookID { get; set; }
        public CookEntity Cook { get; set; }
        public int DishID { get; set; }
        public DishEntity Dish { get; set; }
    }
}
