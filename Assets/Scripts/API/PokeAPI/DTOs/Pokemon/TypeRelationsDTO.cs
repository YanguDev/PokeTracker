namespace PokeTracker.API.PokeApi.DTOs
{
    public class TypeRelationsDTO
    {
        public NamedAPIResourceDTO<TypeDTO>[] no_damage_to;
        public NamedAPIResourceDTO<TypeDTO>[] half_damage_to;
        public NamedAPIResourceDTO<TypeDTO>[] double_damage_to;
        public NamedAPIResourceDTO<TypeDTO>[] no_damage_from;
        public NamedAPIResourceDTO<TypeDTO>[] half_damage_from;
        public NamedAPIResourceDTO<TypeDTO>[] double_damage_from;
    }
}
