using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Client(string _name)
        {
            Name = _name;
        }
        public Client()
        {

        }
    }
}
