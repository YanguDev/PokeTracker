using PokeTracker.Core.Keys;

namespace PokeTracker.Core.Data
{
    public class GameVersionData
    {
        public GameVersionKey Key { get; init; }
        public string DisplayName { get; init; }
        public GameVersionGroupKey GroupKey { get; init; }
    }

    public class GameVersionGroupData
    {
        public GameVersionGroupKey Key { get; init; } 
        public GameVersionKey[] GameVersionKeys { get; init; }
        public PokedexKey[] PokedexKeys { get; init;}
    }

    public class GenerationData
    {
        public int GenerationNumber { get; init; }
    }

    public class PokedexData
    {
        public int PokedexNumber { get; init; }
    }
}
