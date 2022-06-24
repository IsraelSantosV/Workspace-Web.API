using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workspace.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public string Batch { get; set; }
        public string ImageURL { get; set; }
    }
}