using Microsoft.AspNetCore.Mvc;
using Workspace.API.Data;

namespace Workspace.API.Services
{
    public abstract class BaseService<T>
    {
        private readonly DataContext m_Repository;

        public BaseService(DataContext context)
        {
            m_Repository = context;
        }
    }
}