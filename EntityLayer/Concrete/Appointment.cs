using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public int ClientId { get; set; }

    }
}
