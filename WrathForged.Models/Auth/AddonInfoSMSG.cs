// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Auth;

[ForgedSerializable(PacketScope.RealmToClient, RealmServerOpCode.SMSG_ADDON_INFO)]
public class AddonInfoSMSG
{
    [SerializableProperty(0, Flags = SerializationFlags.DontSerializeCollectionSize)]
    public List<SecureAddonInfoSMSG> SecureAddons { get; set; } = [];

    [SerializableProperty(1)]
    public List<BannedAddonInfoSMSG> BannedAddons { get; set; } = [];
}
