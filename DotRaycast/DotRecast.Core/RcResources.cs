using System.IO;

namespace DotRecast.Core;

public static class RcResources
{
    public static byte[] Load(string filename)
    {
        var filepath = filename;
        if (!File.Exists(filepath))
        {
            filepath = RcDirectory.SearchFile($"resources/{filename}");
        }

        using var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
        var buffer = new byte[fs.Length];
        _ = fs.Read(buffer, 0, buffer.Length);

        return buffer;
    }
}