using Cysharp.Threading.Tasks;

namespace PokeTracker.API.HTTPClients
{
    public interface IHTTPClient
    {
        public UniTask<string> GetAsync(string url);
    }
}
