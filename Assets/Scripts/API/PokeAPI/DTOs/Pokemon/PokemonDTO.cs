namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonDTO
    {
        public int id;
        public string name;
        public int base_experience;
        public int height;
        public bool is_default;
        public int order;
        public int weight;
        public PokemonAbilityDTO[] abilities;
        public NamedAPIResourceDTO forms;
        public VersionGameIndexDTO[] game_indices;
        public PokemonHeldItemDTO[] held_items;
        public string location_area_encounters;
        public PokemonMoveDTO[] moves;
        public PokemonTypePastDTO[] past_types;
        public PokemonSpritesDTO sprites;
        public PokemonCriesDTO cries;
        public NamedAPIResourceDTO species;
        public PokemonStatDTO[] stats;
        public PokemonTypeDTO[] types;
    }
}
