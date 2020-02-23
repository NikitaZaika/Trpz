using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    class Dish
    {
        private string name_of_dish;
        private int time_of_cooking;
        private int height_of_dish;
        private List<string> ingrid_of_dish = new List<string>();

        public Dish(string name, int time, int height, List<string> ingrid)
        {
            name_of_dish = name;
            time_of_cooking = time;
            height_of_dish = height;
            ingrid_of_dish = ingrid;
        }
        public string Name_of_dish
        { get { return name_of_dish; } set { name_of_dish = value; } }
        public int Time_of_cooking
        { get { return time_of_cooking; } set { time_of_cooking = value; } }
        public int Height_of_dish
        { get { return height_of_dish; } set { height_of_dish = value; } }
        public List<string> Ingrid_of_dish 
        { get { return ingrid_of_dish; }  set { ingrid_of_dish = value; } }

    }
}
