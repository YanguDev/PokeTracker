namespace PokeTracker.API.PokeApi.DTOs
{
    public class StatDTO
    {
        public int id;
        public string name;
        public int game_index;
        public bool is_battle_only;
        public MoveStatAffectSetsDTO affecting_moves;
        public NatureStatAffectSetsDTO affecting_natures;
        public APIResourceDTO<CharacteristicDTO>[] characteristics;
        public NamedAPIResourceDTO<MoveDamageClassDTO> move_damage_class;
        public NameDTO[] names;
    }
}
