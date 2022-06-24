using System;
using Microsoft.AspNetCore.Mvc;
using Workspace.API.Models;

namespace Workspace.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public EventController()
        {
        }

        [HttpGet]
        public Event Get()
        {
            return new Event
            {
                EventId = 1,
                Title = "Event Request",
                Local = "City",
                Batch = "Event 1",
                Quantity = 1,
                Date = DateTime.Now.ToString(),
                ImageURL = "image.png"
            };
        }

        [HttpPost]
        public string Post()
        {
            return "Example";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Example: " + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Example: " + id;
        }
    }
}
