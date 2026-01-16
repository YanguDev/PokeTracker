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
        public NamedAPIResourceDTO<ContestTypeDTO> contest_type;
        public APIResourceDTO<ContestEffectDTO> contest_effect;
        public NamedAPIResourceDTO<MoveDamageClassDTO> damage_class;
        public VerboseEffectDTO[] effect_entries;
        public AbilityEffectChangeDTO[] effect_changes;
        public NamedAPIResourceDTO<PokemonDTO>[] learned_by_pokemon;
        public MoveFlavorTextDTO[] flavor_text_entries;
        public NamedAPIResourceDTO<GenerationDTO> generation;
        public MachineVersionDetailDTO[] machines;
        public MoveMetaDataDTO meta;
        public NameDTO[] names;
        public PastMoveStatValuesDTO[] past_values;
        public MoveStatChangeDTO[] stat_changes;
        public APIResourceDTO<SuperContestEffectDTO> super_contest_effect;
        public NamedAPIResourceDTO<MoveTargetDTO> target;
        public NameDTO type;
    }
}
