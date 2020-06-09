﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Cook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }


        public Cook(string _name, string _type)
        {
            Name = _name;
            Type = _type;
        }
        public Cook()
        {

        }
    }
}