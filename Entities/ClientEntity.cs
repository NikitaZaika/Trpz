using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ClientEntity : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
