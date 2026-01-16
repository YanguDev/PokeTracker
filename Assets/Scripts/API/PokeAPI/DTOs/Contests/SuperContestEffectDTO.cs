namespace PokeTracker.API.PokeApi.DTOs
{
    public class SuperContestEffectDTO
    {
        public int id;
        public int appeal;
        public FlavorTextDTO[] flavor_text_entries;
        public NamedAPIResourceDTO<MoveDTO>[] moves;
    }
}
