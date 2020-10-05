using Newtonsoft.Json;

namespace VisitNow.Infra.Backend
{
    public class RequestResultErrorItem
    {
        [JsonProperty("codigo")]
        public string Code { get; set; }
        [JsonProperty("mensagem")]
        public string Message { get; set; }
    }
}
