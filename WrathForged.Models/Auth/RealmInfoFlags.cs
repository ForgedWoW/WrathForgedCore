namespace WrathForged.Models.Auth
{
    [Flags]
    public enum RealmInfoFlags : byte
    {
        VersionMismatch = 0x1,
        Offline = 0x2,
    }
}
