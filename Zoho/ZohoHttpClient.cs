using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Starship.Core.Utility;

namespace Starship.Integration.Zoho {
    public class ZohoHttpClient : Disposable {

        public ZohoHttpClient(string authToken, string organizationId) {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Zoho-authtoken", authToken);
            Client.DefaultRequestHeaders.Add("X-com-zoho-subscriptions-organizationid", organizationId);
        }

        public async Task<HttpResponseMessage> Put<T>(string path, T request) {
            return await Client.PutAsync(new Uri(path), new StringContent(JsonConvert.SerializeObject(request)));
        }

        public async Task<HttpResponseMessage> Delete<T>(string path, T request) {
            return await Client.DeleteAsync(new Uri(path));
        }

        public async Task<HttpResponseMessage> Get<T>(string path, T request) {
            return await Client.GetAsync(new Uri(path));
        }
        
        public async Task<HttpResponseMessage> Post<T>(string path, T request) {
            return await Client.PostAsync(new Uri(path), new StringContent(JsonConvert.SerializeObject(request)));
        }

        public async Task<R> Post<T, R>(string path, T request) {
            var response = await Post(path, request);
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<R>(json);
        }

        public override void Disposed() {
            Client?.Dispose();
        }
        
        private HttpClient Client { get; set; }
    }
}