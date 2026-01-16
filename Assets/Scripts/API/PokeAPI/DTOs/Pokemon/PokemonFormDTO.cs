namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonFormDTO
    {
        public int id;
        public string name;
        public int order;
        public int form_order;
        public bool is_default;
        public bool is_battle_only;
        public bool is_mega;
        public string form_name;
        public NamedAPIResourceDTO<PokemonDTO> pokemon;
        public PokemonFormTypeDTO[] types;
        public PokemonFormSpritesDTO sprites;
        public NamedAPIResourceDTO<VersionGroupDTO> version_group;
        public NameDTO[] names;
        public NameDTO[] form_names;
    }
}
