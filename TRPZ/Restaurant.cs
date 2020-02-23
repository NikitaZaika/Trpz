using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    static class Restaurant
    {
        static private List<Cook> cooks = new List<Cook>();
        static private List<Dish> dishes = new List<Dish>();
        static private List<Furnace> furnaces = new List<Furnace>();
        static public List<Furnace> Furnaces
        {
            get { return furnaces; }
            set { furnaces = value; }
        }
        static public List<Dish> Dishes
        {
            get { return dishes; }
            set { dishes = value; }
        }
        static public List<Cook> Cooks
        {
            get { return cooks; }
            set { cooks = value; }
        }
    }
}
