namespace PokeTracker.Core.Keys
{
    public class GameVersionKey : Key
    {
        protected override string Name => "game";
        
        public GameVersionKey(string identifier) : base(identifier) { }
    }

    public class GameVersionGroupKey : Key
    {
        protected override string Name => "game-group";
        
        public GameVersionGroupKey(string identifier) : base(identifier) { }
    }

    public class GenerationKey : Key
    {
        protected override string Name => "generation";
        
        public GenerationKey(string identifier) : base(identifier) { }
    }

    public class PokedexKey : Key
    {
        protected override string Name => "pokedex";
        
        public PokedexKey(string identifier) : base(identifier) { }
    }
}
