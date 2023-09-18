// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Common.DBC
{
    public class BindingEntry
    {
        public readonly DBCBindingType Type;
        public readonly string Name;

        public BindingEntry(string[] parts)
        {
            Name = parts[1];
            Type = DetermineType(parts[0]);
            if (parts.Length > 2 && parts[2].Equals("string", StringComparison.InvariantCultureIgnoreCase))
                Type = DBCBindingType.STRING;
            if (Name.Length == 0)
                Type = DBCBindingType.UNKNOWN;
        }

        private static DBCBindingType DetermineType(string type) => Enum.TryParse(type.ToUpper(), out DBCBindingType result) ? result : DBCBindingType.UNKNOWN;
    }
}