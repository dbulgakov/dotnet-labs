using System.IO;

namespace lab03;

public class FileReader
{
    public string ReadFile(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"File not found: {path}");
        return File.ReadAllText(path);
    }
}