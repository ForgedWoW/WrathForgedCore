// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    //In Trinitycore this is uint8 error but according to https://github.com/EmberEmu/Ember/blob/spark-new/src/login/grunt/client/LoginChallenge.h
    //It is the protocol version
    /// <summary>
    /// Indicates the authentication protocol to be used.
    /// </summary>
    public enum ProtocolVersion : byte
    {
        //There is a slight difference in protocol for errors between > 1.12.1
        //Slight differences in 1.12.1 and 1.12.3 but nobody uses 1.12.3 so who cares
        //However, the major difference comes at >= 2.4.3
        //So, we'll consider there to be two distinct authentication protocols

        //nawuko in Trinitycore IRC said that these are the values for Protocols
        /// <summary>
        /// Protocol used by clients up until 1.12.3 or build 6141
        /// </summary>
        ProtocolVersionOne = 3,

        /// <summary>
        /// Protocol used for authentication for clients >= 2.4.3 or build 8606
        /// </summary>
        ProtocolVersionTwo = 8
    }
}
