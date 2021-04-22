using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Court
    {
        public int CourtId { get; set; }
        public int CourtNumber { get; set; }
        public string JudgeName{ get; set; }

        public ICollection<Case> Cases { get; set; }
    }
}
