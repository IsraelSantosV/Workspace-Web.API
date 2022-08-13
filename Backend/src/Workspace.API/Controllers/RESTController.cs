using System;
using Microsoft.AspNetCore.Mvc;
using Workspace.API.Data;
using Workspace.API.Managers;
using Workspace.API.Utils;

namespace Workspace.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class RESTController<T> : ControllerBase
    {
        public readonly BaseManager<T> m_Manager;
        public readonly DataContext m_Repository;

        public RESTController(DataContext data)
        {
            m_Repository = data;
        }

        [HttpGet]
        public abstract Response<T> List();
        [HttpGet("{id}")]
        public abstract Response<T> Get(int id);
        [HttpPost]
        public abstract Response<T> Create(T request);
        [HttpPut]
        public abstract Response<T> Update(T request);
        [HttpDelete("{id}")]
        public abstract Response<T> Delete(int id);
    }
}