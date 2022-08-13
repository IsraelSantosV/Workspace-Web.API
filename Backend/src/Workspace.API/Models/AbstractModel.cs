using System;

namespace Workspace.API.Models
{
    public abstract class AbstractModel
    {
        public int Id { get; set; }
        public Guid SharedKey { get; set; }
    }
}