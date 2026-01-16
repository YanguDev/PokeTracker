using Cysharp.Threading.Tasks;
using PokeTracker.API.HTTPClients;

namespace PokeTracker.API
{
    public abstract class APIEndpoint
    {
        protected IHTTPClient httpClient;

        public string BaseURL { get; private set; }

        public APIEndpoint(string baseURL, IHTTPClient httpClient)
        {
            BaseURL = baseURL;
            this.httpClient = httpClient;
        }

        protected UniTask<string> GetAsync(URLBuilder urlBuilder)
        {
            return httpClient.GetAsync(urlBuilder.ToString());
        }

        protected URLBuilder CreateURLBuilder(string endpoint)
        {
            return new URLBuilder(BaseURL)
                .AddPathSegment(endpoint);
        }
    }
}
