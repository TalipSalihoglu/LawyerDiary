using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Bill
    {
        public int BillId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime LastDate { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
