namespace PokeTracker.API.PokeApi.DTOs
{
    public class EvolutionChainDTO
    {
        public int id;
        public NamedAPIResourceDTO<ItemDTO> baby_trigger_item;
        public ChainLinkDTO chain;
    }
}
