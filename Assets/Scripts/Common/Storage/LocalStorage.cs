using PokeTracker.Common.Storage.FileHandlers;
using PokeTracker.Common.Storage.Serializers;

namespace PokeTracker.Common.Storage
{
    public class LocalStorage : IStorage
    {
        private readonly string rootPath;
        private readonly IFileHandler fileHandler;
        private readonly ISerializer serializer;

        public void Save<T>(string key, T data)
        {
            string path = GetPath(key);
            byte[] serializedData = serializer.Serialize(data);
            fileHandler.WriteFile(path, serializedData);
        }

        public bool TryLoad<T>(string key, out T data)
        {
            string path = GetPath(key);
            data = default;
            if (!fileHandler.TryReadFile(path, out byte[] bytes)) return false;

            data = serializer.Deserialize<T>(bytes);
            return true;
        }

        public bool TryDelete(string key)
        {
            string path = GetPath(key);
            return fileHandler.TryDeleteFile(path);
        }

        public bool Exists(string key)
        {
            string path = GetPath(key);
            return fileHandler.FileExists(path);
        }

        private string GetPath(string key)
        {
           return System.IO.Path.Combine(rootPath, key); 
        }
    }
}
