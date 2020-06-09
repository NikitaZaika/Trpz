using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class CookEntity : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
