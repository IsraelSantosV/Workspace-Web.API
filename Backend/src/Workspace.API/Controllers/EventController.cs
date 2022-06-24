using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Workspace.API.Data;
using Workspace.API.Models;

namespace Workspace.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _context.Events.FirstOrDefault(myEvent => myEvent.EventId == id);
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
