namespace PokeTracker.API.PokeApi.DTOs
{
    public class NatureDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO<StatDTO> decreased_stat;
        public NamedAPIResourceDTO<StatDTO> increased_stat;
        public NamedAPIResourceDTO<BerryFlavorDTO> hates_flavor;
        public NamedAPIResourceDTO<BerryFlavorDTO> likes_flavor;
        public NatureStatChangeDTO[] pokeathlon_stat_changes;
        public MoveBattleStylePreferenceDTO[] move_battle_style_preferences;
        public NameDTO[] names;
    }
}
