using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Lawyer
    {
        public int LawyerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string  Password{ get; set; }

        public ICollection<Client> Clients{ get; set; }
    }
}
