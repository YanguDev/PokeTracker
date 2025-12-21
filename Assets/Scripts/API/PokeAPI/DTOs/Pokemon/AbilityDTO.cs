namespace PokeTracker.API.PokeApi.DTOs
{
    public class AbilityDTO
    {
        public int id;
        public string name;
        public bool is_main_series;
        public NamedAPIResourceDTO generation;
        public NameDTO[] names;
        public VerboseEffectDTO[] effect_entries;
        public AbilityEffectChangeDTO[] effect_changes;
        public AbilityFlavorTextDTO[] flavor_text_entries;
        public AbilityPokemonDTO[] pokemon;
    }
}
