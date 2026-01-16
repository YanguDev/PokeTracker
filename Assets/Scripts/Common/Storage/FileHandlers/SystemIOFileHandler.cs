using System.IO;

namespace PokeTracker.Common.Storage.FileHandlers
{
    public class SystemIOFileHandler : IFileHandler
    {
        public void WriteFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public void WriteFile(string path, byte[] content)
        {
            File.WriteAllBytes(path, content);
        }

        public bool TryReadFile(string path, out string content)
        {
            if (!File.Exists(path))
            {
                content = null;
                return false;
            }
            
            content = File.ReadAllText(path);
            return true;
        }

        public bool TryReadFile(string path, out byte[] content)
        {
            if (!File.Exists(path))
            {
                content = null;
                return false;
            }
            
            content = File.ReadAllBytes(path);
            return true;
        }

        public bool TryDeleteFile(string path)
        {
            if (!File.Exists(path)) return false;

            File.Delete(path);
            return true;
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
