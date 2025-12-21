namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonMoveVersionDTO
    {
        public NamedAPIResourceDTO move_learn_method;
        public NamedAPIResourceDTO version_group;
        public int level_learned_at;
        public int order;
    }
}
