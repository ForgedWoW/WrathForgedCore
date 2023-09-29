// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth
{
    public class InstanceCharacters
    {
        public int InstanceId { get; set; }
        public int AccountId { get; set; }
        public int CharacterId { get; set; }
        public DateTime JoinTime { get; set; }
        public DateTime LastLeaveTime { get; set; }
        public DateTime LeaveCount { get; set; }

        public virtual Account? Account { get; set; }
        public virtual InstanceList? InstanceList { get; set; }
    }
}
