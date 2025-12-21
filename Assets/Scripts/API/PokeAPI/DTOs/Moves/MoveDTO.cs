namespace PokeTracker.API.PokeApi.DTOs
{
    public class MoveDTO
    {
        public int id;
        public string name;
        public int accuracy;
        public int effect_chance;
        public int pp;
        public int priority;
        public int power;
        public ContestComboSetsDTO contest_combos;
        public NamedAPIResourceDTO contest_type;
        public APIResourceDTO contest_effect;
        public NamedAPIResourceDTO damage_class;
        public VerboseEffectDTO[] effect_entries;
        public AbilityEffectChangeDTO[] effect_changes;
        public NamedAPIResourceDTO[] learned_by_pokemon;
        public MoveFlavorTextDTO[] flavor_text_entries;
        public NamedAPIResourceDTO generation;
        public MachineVersionDetailDTO[] machines;
        public MoveMetaDataDTO meta;
        public NameDTO[] names;
        public PastMoveStatValuesDTO[] past_values;
        public MoveStatChangeDTO[] stat_changes;
        public APIResourceDTO super_contest_effect;
        public NamedAPIResourceDTO target;
        public NameDTO type;
    }
}
