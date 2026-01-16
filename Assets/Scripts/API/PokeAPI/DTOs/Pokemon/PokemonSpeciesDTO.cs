namespace PokeTracker.API.PokeApi.DTOs
{
    public class PokemonSpeciesDTO
    {
        public int id;
        public string name;
        public int order;
        public int gender_rate;
        public int capture_rate;
        public int base_happiness;
        public bool is_baby;
        public bool is_legendary;
        public bool is_mythical;
        public int hatch_counter;
        public bool has_gender_differencies;
        public bool forms_switchable;
        public NamedAPIResourceDTO<GrowthRateDTO> growth_rate;
        public PokemonSpeciesDexEntryDTO[] pokedex_numbers;
        public NamedAPIResourceDTO<EggGroupDTO>[] egg_groups;
        public NamedAPIResourceDTO<PokemonColorDTO> color;
        public NamedAPIResourceDTO<PokemonShapeDTO> shape;
        public NamedAPIResourceDTO<PokemonSpeciesDTO> evolves_from_species;
        public APIResourceDTO<EvolutionChainDTO> evolution_chain;
        public NamedAPIResourceDTO<PokemonHabitatDTO> habitat;
        public NamedAPIResourceDTO<GenerationDTO> generation;
        public NameDTO[] names;
        public PalParkEncounterAreaDTO[] pal_park_encounters;
        public FlavorTextDTO[] flavor_text_entries;
        public DescriptionDTO[] form_descriptions;
        public GenusDTO[] genera;
        public PokemonSpeciesVarietyDTO[] varieties;
    }
}
