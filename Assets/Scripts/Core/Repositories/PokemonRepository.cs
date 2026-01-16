using PokeTracker.Core.Data;
using Cysharp.Threading.Tasks;

namespace PokeTracker.Core.Repositories
{
    public class PokemonRepository
    {
        private readonly IPokemonDataSource pokemonDataSource;

        public PokemonRepository(IPokemonDataSource pokemonDataSource)
        {
            this.pokemonDataSource = pokemonDataSource;
        }

        public UniTask<int> GetCount()
        {
            return pokemonDataSource.GetPokemonCount();
        }

        public UniTask<PokemonData> GetByID(int id)
        {
            return pokemonDataSource.GetPokemonDataByID(id);
        }

        public UniTask<PokemonData> GetByIdentifier(string identifier)
        {
            return pokemonDataSource.GetPokemonDataByIdentifier(identifier);
        }
    }
}
