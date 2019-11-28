using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace IncidentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        private readonly ILogger<IncidentsController> _logger;

        public IncidentsController(ILogger<IncidentsController> logger)
        {
            _logger = logger;
        }

        // https://localhost:44300/api/incidents/23
        [HttpGet("{incidentId}")]
        public Incident Get(string incidentId)
        {
            return new Incident()
            {
                CustomerFirstName = "Hansi",
                CustomerId = Guid.NewGuid().ToString("D"),
                CustomerLastName = "Huber",
                Id = incidentId,
                Description = "Demo Beschreibung",
                Subject = "Customer cannot log in"
            };
        }
    }
}
