namespace PokeTracker.API.PokeApi.DTOs
{
    public class EvolutionDetailDTO
    {
        public NamedAPIResourceDTO<ItemDTO> item;
        public NamedAPIResourceDTO<EvolutionTriggerDTO> trigger;
        public int gender;
        public NamedAPIResourceDTO<ItemDTO> held_item;
        public NamedAPIResourceDTO<MoveDTO> known_move;
        public NamedAPIResourceDTO<TypeDTO> known_move_type;
        public NamedAPIResourceDTO<LocationDTO> location;
        public int min_level;
        public int min_happiness;
        public int min_beauty;
        public bool needs_overworld_rain;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> party_species;
        public NamedAPIResourceDTO<TypeDTO> party_type;
        public int relative_physical_stats;
        public string time_of_day;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> trade_species;
        public bool turn_upside_down;
    }
}
