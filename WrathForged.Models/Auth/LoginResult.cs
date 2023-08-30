namespace WrathForged.Models.Auth
{
    /// <summary>
	/// Enumeration of all possible login results.
	/// </summary>
	public enum LoginResult //TODO: Find out type in packet
    {
        Ok = 0x00,
        Failed = 0x01,
        Failed2 = 0x02,
        Banned = 0x03,
        UnknownAccount = 0x04,
        UnknownAccount3 = 0x05,
        AlreadyOnline = 0x06,
        NoGameTime = 0x07,
        DatabaseBusy = 0x08,
        BadVersion = 0x09,
        DownloadFile = 0x0A,
        Failed3 = 0x0B,
        Suspended = 0x0C,
        Failed4 = 0x0D,
        Connected = 0x0E,
        ParentalControlBlocked = 0x0F,
        LockedEnforced = 0x10
    };
}
