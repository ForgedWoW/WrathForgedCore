// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth
{
    public class InstanceMaps
    {
        public int InstanceId { get; set; }
        public int MapId { get; set; }

        public virtual required InstanceList InstanceList { get; set; }
    }
}
