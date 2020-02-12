using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {

    public class GetZohoPayments : ZohoSubscriptionsRequest<GetZohoPayments.Response> {
        
        public GetZohoPayments() : base("payments", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("payments")]
            public List<ZohoPayment> Payments { get; set; }
        }
    }
}