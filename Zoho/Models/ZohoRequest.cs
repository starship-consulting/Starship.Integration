using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Starship.Integration.Zoho.Requests;

namespace Starship.Integration.Zoho.Models {
    public abstract class ZohoRequest<R> where R : ZohoResponseMessage {

        protected ZohoRequest(string url, HttpMethod method) {
            Url = url;
            Method = method;
        }

        protected virtual object GetRequestContent() {
            return this;
        }

        public async Task<R> RequestAsync(ZohoHttpClient client) {
            
            HttpResponseMessage response;

            if(Method == HttpMethod.Post) {
                response = await client.Post(Url, this);
            }
            else if(Method == HttpMethod.Delete) {
                response = await client.Delete(Url, this);
            }
            else if(Method == HttpMethod.Put) {
                response = await client.Put(Url, this);
            }
            else {
                response = await client.Get(Url, this);
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<R>(content);
        }

        private string Url { get; set; }

        private HttpMethod Method { get; set; }
    }
}