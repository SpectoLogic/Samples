using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentAPI
{
    public class Incident
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
    }
}
