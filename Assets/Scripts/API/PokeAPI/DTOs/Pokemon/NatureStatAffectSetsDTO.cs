namespace PokeTracker.API.PokeApi.DTOs
{
    public class NatureStatAffectSetsDTO
    {
        public NamedAPIResourceDTO<NatureDTO>[] increase;
        public NamedAPIResourceDTO<NatureDTO>[] decrease;
    }
}
