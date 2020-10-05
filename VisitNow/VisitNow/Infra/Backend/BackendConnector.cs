using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VisitNow.Infra.Backend
{
    public class BackendConnector
    {
        private HttpClient _client;
        private string _baseAddress;

        public BackendConnector(string baseAddress) {
            _baseAddress = baseAddress;
        }

        public BackendConnector()
        {
            _baseAddress = Constants.CORE_API_ADDRESS; // ResourceManager.GetResourceFromValuesByKey("REST_API_CORE_BASE_ADDRESS");
        }

        private HttpClient GetClient(string authorizationToken = "") {
            if (_client == null)
            {
                _client = new HttpClient();

                if (!string.IsNullOrEmpty(authorizationToken))
                {
                    _client.DefaultRequestHeaders.Add("Authorization", authorizationToken);
                }
            }
                
            return _client;
        }

        public async Task<string> GetStringJsonDataAsync(string url, string query = "", string authorizationToken = "")
        {
            var uri = new Uri($"{_baseAddress}{url}?{query}");

            var response = await GetClient(authorizationToken).GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return content;
            }
            else
            {
                throw new RESTServiceCallException() { HttpStatusCode = response.StatusCode.ToString() };
            }
        }

        public async Task<BackendResponseResult> GetDataAsync(string url, string query = "", string authorizationToken = "")
        {
            var uri = new Uri($"{_baseAddress}{url}?{query}");

            var response = await GetClient(authorizationToken).GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return ParseFromJSONServiceResult(content);
            }
            else
            {
                throw new RESTServiceCallException() { HttpStatusCode = response.StatusCode.ToString() };
            }

        }

        public async Task<BackendResponseResult> SaveOrUpdateAsync<T>(T item,
            string method, 
            string url, 
            string queryString = "",
            string authorizationToken = "")
        {
            var uri = new Uri(string.Concat(this._baseAddress, url));
            var json = "";
            if (item != null)
            {
                json = JsonConvert.SerializeObject(item, Formatting.None,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
            }

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;

            if (method.ToUpper().Equals("POST"))
            {
                response = await GetClient(authorizationToken).PostAsync(uri, content);
            }
            else if (method.ToUpper().Equals("PUT"))
            {
                response = await GetClient(authorizationToken).PutAsync(uri, content);
            }
            else
            {
                throw new Exception("Http verb not supported.");
            }

            var outputContent = "";

            if (response.IsSuccessStatusCode)
            {
                outputContent = response.Content.ReadAsStringAsync().Result;

                if (ParseFromJSONServiceResult(outputContent).Result == ERequestResult.SUCESSO)
                {
                    return ParseFromJSONServiceResult(outputContent);
                }
                else
                {
                    Console.WriteLine(ParseFromJSONServiceResult(outputContent));
                    throw new RESTServiceCallException()
                    {
                        ErrorList = ParseFromJSONServiceResult(outputContent).Error
                    };
                }
            }
            else
            {
                throw new RESTServiceCallException()
                {
                    HttpStatusCode = response.StatusCode.ToString()
                };
            }
        }

        public async Task<BackendResponseResult> DeleteTodoItemAsync(
            string url, 
            string queryString = "", 
            string authorizationToken = "")
        {
            var uri = new Uri(string.Concat(this._baseAddress, url, queryString));
            var response = await GetClient(authorizationToken).DeleteAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var outputContent = await response.Content.ReadAsStringAsync();
                return ParseFromJSONServiceResult(outputContent);
            }
            else
            {
                throw new RESTServiceCallException() { HttpStatusCode = response.StatusCode.ToString() };
            }
        }

        private BackendResponseResult ParseFromJSONServiceResult(string serviceResult) {
            BackendResponseResult serviceResutlJSONObject = JsonConvert.DeserializeObject<BackendResponseResult>(serviceResult);
            return serviceResutlJSONObject;
        }
    }
}
