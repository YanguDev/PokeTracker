namespace PokeTracker.API.PokeApi.DTOs
{
    public class CharacteristicDTO
    {
        public int id;
        public int gene_modulo;
        public int[] possible_values;
        public NamedAPIResourceDTO<StatDTO> highest_stat;
        public DescriptionDTO[] descriptions;
    }
}
