using Cysharp.Threading.Tasks;
using PokeTracker.API.HTTPClients;
using System.Net.Http;
using UnityEngine;
using UnityEngine.Networking;

namespace PokeTracker.API
{
    public class UnityHTTPClient : IHTTPClient
    {
        public async UniTask<string> GetAsync(string url)
        {
            using var request = UnityWebRequest.Get(url);
            await request.SendWebRequest();
            
            if (request.result != UnityWebRequest.Result.Success)
            {
                throw new HttpRequestException(request.error);
            }

            return request.downloadHandler.text;
        }
    }
}
