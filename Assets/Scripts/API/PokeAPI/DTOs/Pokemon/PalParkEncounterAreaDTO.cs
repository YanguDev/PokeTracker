namespace PokeTracker.API.PokeApi.DTOs
{
    public class PalParkEncounterAreaDTO
    {
        public int base_score;
        public int rate;
        public NamedAPIResourceDTO<PalParkAreaDTO> area;
    }
}
