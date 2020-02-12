using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {

    public class GetZohoCustomers : ZohoSubscriptionsRequest<GetZohoCustomers.Response> {
        
        public GetZohoCustomers() : base("customers", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("customers")]
            public List<ZohoCustomer> Customers { get; set; }
        }
    }
}