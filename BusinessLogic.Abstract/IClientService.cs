using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstract
{
    public interface IClientService
    {
        public IEnumerable<Client> GetAll();
        public Client GetProductByName(string name);
    }
}
