using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Requests {

    public class ZohoResponseMessage {

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}