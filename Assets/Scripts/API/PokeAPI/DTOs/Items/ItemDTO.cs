namespace PokeTracker.API.PokeApi.DTOs
{
    public class ItemDTO
    {
        public int id;
        public string name;
        public int cost;
        public int fling_power;
        public NamedAPIResourceDTO<ItemFlingEffectDTO> fling_effect;
        public NamedAPIResourceDTO<ItemAttributeDTO>[] attributes;
        public NamedAPIResourceDTO<ItemCategoryDTO> category;
        public VerboseEffectDTO[] effect_entries;
        public VersionGroupFlavorTextDTO[] flavor_text_entries;
        public GenerationGameIndexDTO[] game_indices;
        public NameDTO names;
        public ItemSpritesDTO sprites;
        public ItemHolderPokemonDTO[] held_by_pokemon;
        public APIResourceDTO<EvolutionChainDTO> baby_trigger_for;
        public MachineVersionDetailDTO[] machines;
    }
}
