using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ClientManager : IClientService
    {
        private IClientDal _clientDal;
        public ClientManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }

        public void Add(Client client)
        {
            _clientDal.Add(client);
        }

        public void Delete(Client client)
        {
            client.Status = false;
            _clientDal.Update(client);
        }

        public Client Get(int id)
        {
            var client= _clientDal.Get(id);
            return client;
        }

        public IList<Client> GetList()
        {
            return _clientDal.GetList().Where(x => x.Status == true).ToList();
        }

        public void Update(Client client)
        {
            _clientDal.Update(client);
        }
    }
}
