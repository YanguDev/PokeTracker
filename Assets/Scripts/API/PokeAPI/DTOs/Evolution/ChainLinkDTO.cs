namespace PokeTracker.API.PokeApi.DTOs
{
    public class ChainLinkDTO
    {
        public bool is_baby;
        public NamedAPIResourceDTO species;
        public EvolutionDetailDTO[] evolution_details;
        public ChainLinkDTO[] evolves_to;
    }
}
