using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Time { get; set; }


        public Dish(string _name, int _cost, int _time)
        {
            Name = _name;
            Cost = _cost;
            Time = _time;
        }
        public Dish(string _name, int _cost, int _time, int _id)
        {
            Name = _name;
            Cost = _cost;
            Time = _time;
            Id = _id;
        }
        public Dish()
        {

        }
    }
}
