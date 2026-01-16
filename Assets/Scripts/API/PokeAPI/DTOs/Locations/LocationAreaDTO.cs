namespace PokeTracker.API.PokeApi.DTOs
{
    public class LocationAreaDTO
    {
        public int id;
        public string name;
        public int game_index;
        public EncounterMethodRateDTO[] encounter_method_rates;
        public NamedAPIResourceDTO<LocationDTO> location;
        public NameDTO[] names;
        public PokemonEncounterDTO[] pokemon_encounters;
    }
}
