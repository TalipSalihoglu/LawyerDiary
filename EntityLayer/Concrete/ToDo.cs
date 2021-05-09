using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class ToDo
    {
        public int Id{ get; set; }
        public int LawyerId { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public bool Status{ get; set; }

    }
}
