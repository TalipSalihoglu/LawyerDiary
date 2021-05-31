using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Case
    {
        public int CaseId{ get; set; }
        public string Topic{ get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CaseDate { get; set; }

        public int LawyerId { get; set; }
        public int CourtId { get; set; }
        public int ClientId { get; set; }


    }
}
