using System;
using System.Collections.Generic;
using System.Text;

namespace TRPZ
{
    static class InfoOffice
    {
        static private List<Restaurant> restaurants = new List<Restaurant>();
        static public List<Restaurant> Restaurants
        {
            get { return restaurants; }
            set { restaurants = value; }
        }
        static private Client clients;
        static public Client Clients
        {
            get { return clients; }
            set { clients = value; }
        }
    }
}
