namespace DotRecast.Core;

public static class RcHashCodes
{
    public static int CombineHashCodes(int h1, int h2) => ((h1 << 5) + h1) ^ h2;
}