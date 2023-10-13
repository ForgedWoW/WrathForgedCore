// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

public class InstanceList
{
    public uint Id { get; set; }
    public uint Realm { get; set; }
    public string IpAddress { get; set; } = string.Empty;
    public uint Port { get; set; }
    public uint PlayerCount { get; set; }
    public DateTime Created { get; set; }

    public virtual Realmlist? RealmList { get; set; }
    public virtual ICollection<InstanceMaps> InstanceMaps { get; set; } = new List<InstanceMaps>();
    public virtual ICollection<InstanceCharacters> InstanceCharacters { get; set; } = new List<InstanceCharacters>();
}
