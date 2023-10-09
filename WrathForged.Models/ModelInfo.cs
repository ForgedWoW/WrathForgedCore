// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models
{
    public class ModelInfo
    {
        public Type Type { get; set; }
        public List<PropertyMeta> Properties { get; set; } = [];
        public int Size { get; set; }

        public ModelInfo(Type type, List<PropertyMeta> properties, int size)
        {
            Type = type;
            Properties = properties;
            Size = size;
        }
    }
}
