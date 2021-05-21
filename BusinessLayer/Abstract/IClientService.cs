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
        int GetClientIdWithName(string name);
        IList<Client> Search(string name);
        void Add(Client client);
        void Update(Client client);
        void Delete(Client client);
    }
}
