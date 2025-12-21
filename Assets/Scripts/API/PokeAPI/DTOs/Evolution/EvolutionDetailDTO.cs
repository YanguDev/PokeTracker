namespace PokeTracker.API.PokeApi.DTOs
{
    public class EvolutionDetailDTO
    {
        public NamedAPIResourceDTO item;
        public NamedAPIResourceDTO trigger;
        public int gender;
        public NamedAPIResourceDTO held_item;
        public NamedAPIResourceDTO known_move;
        public NamedAPIResourceDTO known_move_type;
        public NamedAPIResourceDTO location;
        public int min_level;
        public int min_happiness;
        public int min_beauty;
        public bool needs_overworld_rain;
        public NamedAPIResourceDTO party_species;
        public NamedAPIResourceDTO party_type;
        public int relative_physical_stats;
        public string time_of_day;
        public NamedAPIResourceDTO trade_species;
        public bool turn_upside_down;
    }
}
