namespace PokeTracker.API.PokeApi.DTOs
{
    public class NatureDTO
    {
        public int id;
        public string name;
        public NamedAPIResourceDTO decreased_stat;
        public NamedAPIResourceDTO increased_stat;
        public NamedAPIResourceDTO hates_flavor;
        public NamedAPIResourceDTO likes_flavor;
        public NatureStatChangeDTO[] pokeathlon_stat_changes;
        public MoveBattleStylePreferenceDTO[] move_battle_style_preferences;
        public NameDTO[] names;
    }
}
