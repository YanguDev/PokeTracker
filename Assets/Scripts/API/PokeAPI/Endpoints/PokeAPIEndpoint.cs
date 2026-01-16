using Cysharp.Threading.Tasks;
using PokeTracker.API.HTTPClients;

namespace PokeTracker.API.PokeApi.Endpoints
{
    public class PokeAPIEndpoint : APIEndpoint
    {
        public string Endpoint { get; protected set; }

        public PokeAPIEndpoint(string endpoint, IHTTPClient httpClient)
            : base("https://pokeapi.co/api/v2/", httpClient)
        {
            Endpoint = endpoint;
        }

        public virtual UniTask<string> RequestPaginated()
        {
            var urlBuilder = CreateURLBuilder();
            return GetAsync(urlBuilder);
        }

        public virtual UniTask<string> RequestPaginated(int limit, int offset = 0)
        {
            var urlBuilder = CreateURLBuilder();
            urlBuilder.AddParameter("limit", limit.ToString());
            urlBuilder.AddParameter("offset", offset.ToString());

            return GetAsync(urlBuilder);
        }

        public virtual UniTask<string> RequestAll()
        {
            return RequestPaginated(-1);
        }

        public virtual UniTask<string> RequestByID(int id)
        {
            var urlBuilder = CreateURLBuilder()
                .AddPathSegment(id.ToString());

            return GetAsync(urlBuilder);
        }

        public virtual UniTask<string> RequestByName(string name)
        {
            var urlBuilder = CreateURLBuilder()
                .AddPathSegment(name);

            return GetAsync(urlBuilder);
        }

        protected virtual URLBuilder CreateURLBuilder() => CreateURLBuilder(Endpoint);
    }
}
