namespace PokeTracker.Common.Storage
{
    public interface IStorage
    {
        void Save<T>(string key, T data);
        bool TryLoad<T>(string key, out T data);
        bool Exists(string key);
        bool TryDelete(string key);
    }
}
