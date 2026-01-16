namespace PokeTracker.API.PokeApi.DTOs
{
    public class EggGroupDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> pokemon_species;
    }
}
