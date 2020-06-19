using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Cook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CountOfOrders { get; set; }


        public Cook(string _name, string _type)
        {
            CountOfOrders = 0;
            Name = _name;
            Type = _type;
        }
        public Cook(string _name, string _type, int _id)
        {
            CountOfOrders = 0;
            Name = _name;
            Type = _type;
            Id = _id;
        }
        public Cook()
        {

        }
    }
}
