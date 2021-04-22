using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IClientService
    {
        Client Get(int id);
        IList<Client> GetList();
        void Add(Client client);
        void Update(Client client);
        void Delete(Client client);
    }
}
