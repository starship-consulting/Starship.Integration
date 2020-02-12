using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {
    public class ZohoPlan {

        [JsonProperty("plan_code")]
        public string Code { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("exclude_trial")]
        public bool ExcludeTrial { get; set; }
    }
}