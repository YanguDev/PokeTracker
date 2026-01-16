namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveMetaDataDTO
    {
        public NamedAPIResourceDTO<MoveAilmentDTO> ailment;
        public NamedAPIResourceDTO<MoveCategoryDTO> category;
        public int min_hits;
        public int max_hits;
        public int min_turns;
        public int max_turns;
        public int drain;
        public int healing;
        public int crit_rate;
        public int ailment_chance;
        public int flinch_chance;
        public int stat_chance;
    }
}
