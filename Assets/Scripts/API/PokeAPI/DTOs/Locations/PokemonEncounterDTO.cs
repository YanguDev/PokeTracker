namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonEncounterDTO
    {
        public NamedAPIResourceDTO<PokemonDTO> pokemon;
        public VersionEncounterDetailDTO[] version_details;
    }
}
