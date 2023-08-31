﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Serialization;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable]
    public class AuthResponse
    {
        [SerializableProperty(0)]
        public AuthStatus Status { get; set; }

        [SerializableProperty(1, DontSerializeWhenDefaultValue = true)]
        public uint QueuePosition { get; set; }

        [SerializableProperty(2, DontSerializeWhenIndexIsDefaultValue = 1)]
        public byte Unknown { get; set; }
    }
}