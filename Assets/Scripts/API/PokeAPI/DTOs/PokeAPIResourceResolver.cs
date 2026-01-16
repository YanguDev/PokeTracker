using System;
using PokeTracker.API.HTTPClients;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;

namespace PokeTracker.API.PokeApi.DTOs
{
    public static class PokeAPIResourceResolver
    {
        public static async UniTask<TData[]> ResolveAll<TDTO, TData>(
            APIResourceDTO<TDTO>[] resources,
            IHTTPClient client,
            Func<TDTO, TData> mapper)
        {
            var tasks = resources.Select(resource => Resolve(resource, client, mapper));

            return await UniTask.WhenAll(tasks);
        }

        public static async UniTask<TData> Resolve<TDTO, TData>(
            APIResourceDTO<TDTO> resource,
            IHTTPClient client,
            Func<TDTO, TData> mapper)
        {
            string json = await client.GetAsync(resource.url);
            TDTO dto = JsonConvert.DeserializeObject<TDTO>(json);

            return mapper(dto);
        }
    }
}
