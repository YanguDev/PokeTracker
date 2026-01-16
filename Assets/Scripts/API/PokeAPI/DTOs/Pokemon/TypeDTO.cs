namespace PokeTracker.API.PokeApi.DTOs
{
    public class TypeDTO
    {
        public int id;
        public string name;
        public TypeRelationsDTO damage_relations;
        public TypeRelationsPastDTO[] past_damage_relations;
        public GenerationGameIndexDTO[] game_indices;
        public NamedAPIResourceDTO<GenerationDTO> generation;
        public NamedAPIResourceDTO<MoveDamageClassDTO> move_damage_class;
        public NameDTO[] names;
        public TypePokemonDTO[] pokemon;
        public NamedAPIResourceDTO<MoveDTO>[] moves;
    }
}
