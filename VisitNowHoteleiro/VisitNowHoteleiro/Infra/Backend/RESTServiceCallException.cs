using System;
using System.Collections.Generic;

namespace VisitNowHoteleiro.Infra.Backend
{
    public class RESTServiceCallException : Exception
    {
        public string HttpStatusCode { get; set; }
        public List<RequestResultErrorItem> ErrorList { get; set; }
    }
}
