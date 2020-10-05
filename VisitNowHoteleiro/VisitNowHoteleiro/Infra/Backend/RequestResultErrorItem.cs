using Newtonsoft.Json;

namespace VisitNowHoteleiro.Infra.Backend
{
    public class RequestResultErrorItem
    {
        [JsonProperty("codigo")]
        public string Code { get; set; }
        [JsonProperty("mensagem")]
        public string Message { get; set; }
    }
}
