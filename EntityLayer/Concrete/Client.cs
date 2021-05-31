using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Client
    {
        public int  ClientId{ get; set; }
        public string ClientName { get; set; }
        public string Address{ get; set; }
        public string Email { get; set; }
        public bool Status{ get; set; }

        public int LawyerId { get; set; }
       
    }
}
