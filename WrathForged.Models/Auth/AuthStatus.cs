namespace WrathForged.Models.Auth
{
    public enum AuthStatus
    {
        STATUS_CHALLENGE = 0,
        STATUS_LOGON_PROOF,
        STATUS_RECONNECT_PROOF,
        STATUS_AUTHED,
        STATUS_WAITING_FOR_REALM_LIST,
        STATUS_CLOSED
    };
}
