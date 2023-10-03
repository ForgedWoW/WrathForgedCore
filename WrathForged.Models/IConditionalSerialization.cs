// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models
{
    public interface IConditionalSerialization
    {
        bool ShouldDeserialize(object obj, PropertyMeta currentProperty, List<PropertyMeta> allProperties);
    }
}
