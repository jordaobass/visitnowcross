using Newtonsoft.Json;
using System.Collections.Generic;

namespace VisitNow.Infra.Backend
{
    public partial class BackendResponseResult : BackendConnector
    {
        [JsonProperty("metodo")]
        public string Method { get; set; }
        [JsonProperty("resultado")]
        public ERequestResult Result { get; set; }
        [JsonProperty("msgSaida")]
        public List<object> OutputPayload { get; set; }
        [JsonProperty("erro")]
        public List<RequestResultErrorItem> Error { get; set; }
    }
}