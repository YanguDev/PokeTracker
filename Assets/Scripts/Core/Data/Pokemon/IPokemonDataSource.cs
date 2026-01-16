using Cysharp.Threading.Tasks;

namespace PokeTracker.Core.Data
{
    public interface IPokemonDataSource
    {
        public UniTask<int> GetPokemonCount();
        public UniTask<PokemonData> GetPokemonDataByID(int id);
        public UniTask<PokemonData> GetPokemonDataByIdentifier(string identifier);
    }
}
