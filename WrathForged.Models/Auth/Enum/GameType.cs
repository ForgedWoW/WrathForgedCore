namespace WrathForged.Models.Auth
{
    /// <summary>
	/// Enumeration of all games that authenticate with the WoW protocol
	/// </summary>
	public enum GameType : byte //uint8 gamename[4]; (Enum string)
    {
        /// <summary>
        /// World of Warcraft
        /// </summary>
        WoW = 1,
    }
}
