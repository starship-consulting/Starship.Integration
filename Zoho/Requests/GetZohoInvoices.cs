using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {

    public class GetZohoInvoices : ZohoSubscriptionsRequest<GetZohoInvoices.Response> {
        
        public GetZohoInvoices() : base("invoices", HttpMethod.Get) {
        }
        
        public class Response : ZohoResponseMessage {

            [JsonProperty("invoices")]
            public List<ZohoInvoice> Invoices { get; set; }
        }
    }
}