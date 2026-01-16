namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonMoveVersionDTO
    {
        public NamedAPIResourceDTO<MoveLearnMethodDTO> move_learn_method;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
        public int level_learned_at;
        public int order;
    }
}
