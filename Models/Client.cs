using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Client(string _name)
        {
            Name = _name;
        }
        public Client(string _name, int _id)
        {
            Name = _name;
            Id = _id;
        }
        public Client()
        {

        }
    }
}
