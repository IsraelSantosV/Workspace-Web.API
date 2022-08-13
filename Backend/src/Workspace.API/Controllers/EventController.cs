using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Workspace.API.Data;
using Workspace.API.Managers;
using Workspace.API.Models;
using Workspace.API.Utils;

namespace Workspace.API.Controllers
{
    public class EventController : RESTController<Event>
    {
        public EventController(DataContext data) : base(data) { }

        public override Response<Event> Create(Event request)
        {
            request.SharedKey = Guid.NewGuid();
            m_Repository.Events.Add(request);
            m_Repository.SaveChanges();
            
            var requestData = new List<Event> {
                m_Repository.Events.FirstOrDefault(e => e.Id == request.Id)
            };
            return new Response<Event>(requestData, HttpStatusCode.OK);
        }

        public override Response<Event> Delete(int id)
        {
            Event targetEvent = m_Repository.Events.FirstOrDefault(e => e.Id == id);
            if(targetEvent == null)
            {
                return new Response<Event>(null, HttpStatusCode.NotFound);
            }

            m_Repository.Events.Remove(targetEvent);
            m_Repository.SaveChanges();
            return new Response<Event>(new List<Event>{ targetEvent }, HttpStatusCode.OK);
        }

        public override Response<Event> Get(int id)
        {
            Event targetEvent = m_Repository.Events.FirstOrDefault(e => e.Id == id);
            if(targetEvent == null)
            {
                return new Response<Event>(null, HttpStatusCode.NotFound);
            }

            return new Response<Event>(new List<Event> { targetEvent }, HttpStatusCode.OK);
        }

        public override Response<Event> List()
        {
            IEnumerable<Event> events = m_Repository.Events.AsEnumerable();
            return new Response<Event>(events.ToList(), HttpStatusCode.Accepted);
        }

        public override Response<Event> Update(Event request)
        {
            Event targetEvent = m_Repository.Events.FirstOrDefault(e => e.Id == request.Id);
            if(targetEvent == null)
            {
                return new Response<Event>(null, HttpStatusCode.NotFound);
            }

            m_Repository.Update(request);
            m_Repository.SaveChanges();
            return new Response<Event>(new List<Event>{ request }, HttpStatusCode.OK);
        }
    }
}
