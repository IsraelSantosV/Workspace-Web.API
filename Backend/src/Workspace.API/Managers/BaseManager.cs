using Workspace.API.Services;

namespace Workspace.API.Managers
{
    public abstract class BaseManager<T>
    {
        public readonly BaseService<T> Service;

        public BaseManager(BaseService<T> service)
        {
            Service = service;
        }
    }
}