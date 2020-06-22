using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class DishEntity : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Time { get; set; }
    }
}
