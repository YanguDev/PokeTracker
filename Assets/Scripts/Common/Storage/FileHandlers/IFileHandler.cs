namespace PokeTracker.Common.Storage.FileHandlers
{
    public interface IFileHandler
    {
        void WriteFile(string path, string content);
        void WriteFile(string path, byte[] content);
        bool TryReadFile(string path, out string content);
        bool TryReadFile(string path, out byte[] content);
        bool TryDeleteFile(string path);
        bool FileExists(string path);
    }
}
