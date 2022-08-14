using System;
using System.Collections.Generic;
using System.Net;

namespace Workspace.API.Utils
{
    [Serializable]
    public class Response<T>
    {
        public List<T> Data { get; private set; }
        public HttpStatusCode HTTPCode { get; private set; }
        
        public string Error { get; set; }

        public Response(List<T> data, HttpStatusCode httpCode)
        {
            Data = new List<T>(data);
            HTTPCode = httpCode;
        }
    }
}