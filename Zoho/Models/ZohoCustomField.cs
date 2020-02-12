using System;
using Newtonsoft.Json;

namespace Starship.Integration.Zoho.Models {

    public class ZohoCustomField {

        public ZohoCustomField() {
        }

        public ZohoCustomField(string label, string value) {
            Label = label;
            Value = value;
        }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}