using System.Net.Http;
using Starship.Integration.Zoho.Models;

namespace Starship.Integration.Zoho.Requests {
    public class UpdateZohoCustomer : ZohoSubscriptionsRequest<ZohoResponseMessage> {
        
        public UpdateZohoCustomer(ZohoCustomer customer)
            : base("customers/" + customer.Id, HttpMethod.Put) {

            Customer = customer;
        }

        protected override object GetRequestContent() {
            return Customer;
        }

        private ZohoCustomer Customer { get; set; }
    }
}