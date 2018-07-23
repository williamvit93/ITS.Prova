using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ITS.Prova.Site.Controllers
{
    public class BaseController : Controller
    {
        private readonly HttpClient _client;

        public BaseController()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:50446"),
                DefaultRequestHeaders = { Accept = { new MediaTypeWithQualityHeaderValue("application/json") } }
            };
        }

        public HttpResponseMessage GetAllResponseMessage(string uri)
        {
            return _client.GetAsync(uri).Result;
        }

        public HttpResponseMessage GetResponseMessage(string uri, int id)
        {
            return _client.GetAsync(uri + id).Result;
        }

        public HttpResponseMessage PostResponseMessage(Object model, string uri)
        {
            return _client.PostAsync(CreateBaseUri(_client.BaseAddress, uri),
                ConvertToHttpContent(model)).Result;
        }

        public HttpResponseMessage PutResponseMessage(Object model, string uri)
        {
            return _client.PutAsync(CreateBaseUri(_client.BaseAddress, uri),
                ConvertToHttpContent(model)).Result;
        }

        private string CreateBaseUri(Uri address, string controllerApi)
        {
            return String.Concat(address, controllerApi);
        }

        private StringContent ConvertToHttpContent(Object model)
        {
            var serializedObject = JsonConvert.SerializeObject(model, Formatting.Indented);
            return new StringContent(serializedObject, System.Text.Encoding.UTF8, "application/json");
        }

        public HttpResponseMessage DeleteResponseMessage(string uri, int id)
        {
            return _client.DeleteAsync(uri + id).Result;
        }

        public string GetResults(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }

    }
}