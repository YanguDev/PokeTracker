namespace PokeTracker.API.PokeApi.DTOs
{
    public class GenderDTO
    {
        public int id;
        public string name;
        public PokemonSpeciesGenderDTO[] pokemon_species_details;
        public NamedAPIResourceDTO<PokemonSpeciesDTO>[] required_for_evolution;
    }
}
