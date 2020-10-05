using System;
using System.Collections.Generic;

namespace VisitNow.Infra.Backend
{
    public class RESTServiceCallException : Exception
    {
        public string HttpStatusCode { get; set; }
        public List<RequestResultErrorItem> ErrorList { get; set; }
    }
}
