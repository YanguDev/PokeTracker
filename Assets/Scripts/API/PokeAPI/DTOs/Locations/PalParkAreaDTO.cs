namespace PokeTracker.API.PokeApi.DTOs
{
    public class PalParkAreaDTO
    {
        public int id;
        public string name;
        public NameDTO[] names;
        public PalParkEncounterSpeciesDTO[] pokemon_encounters;
    }
}
