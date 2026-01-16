namespace PokeTracker.Core.Keys
{
    public abstract class Key
    {
        protected string identifier;

        protected abstract string Name { get; }

        public Key(string identifier)
        {
            this.identifier = identifier;
        }

        public override string ToString()
        {
            return $"{Name}:{identifier}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Key key)
            {
                return ToString().Equals(key.ToString());
            }

            if (obj is string str)
            {
                return ToString().Equals(str);
            }

            return false;
        }
    }
}
