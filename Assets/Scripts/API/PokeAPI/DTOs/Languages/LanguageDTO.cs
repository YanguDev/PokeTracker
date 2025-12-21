namespace PokeTracker.API.PokeApi.DTOs
{
    public class LanguageDTO
    {
        public int id;
        public string name;
        public bool official;
        public string iso639;
        public string iso3166;
        public NameDTO[] names;
    }
}
