// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Core.Enum;
using WrathForged.Models.Instance.Enum;
using WrathForged.Models.Networking;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class PacketRouteAttribute : Attribute
{
    public PacketRouteAttribute(PacketScope scope, uint id)
    {
        Scope = scope;
        Id = new PacketId(id, scope);
    }

    public PacketRouteAttribute(PacketScope scope, AuthServerOpCode id)
    {
        Scope = scope;
        Id = new PacketId(id, scope);
    }

    public PacketRouteAttribute(PacketScope scope, RealmServerOpCode id, bool requiresAuthentication = true, params uint[] requiredRoles)
    {
        Scope = scope;
        Id = new PacketId(id, scope);
        RequireAuthentication = requiresAuthentication;
        RequiredRoles = requiredRoles;
    }

    public PacketRouteAttribute(PacketScope scope, InstanceServerOpCode id)
    {
        Scope = scope;
        Id = new PacketId(id, scope);
    }

    public PacketRouteAttribute(PacketScope scope, ForgedCoreOpCode id)
    {
        Scope = scope;
        Id = new PacketId(id, scope);
    }

    public PacketScope Scope { get; }
    public PacketId Id { get; }
    public bool RequireAuthentication { get; set; }
    public uint[] RequiredRoles { get; set; } = [];
    public int RequiredSecurityLevel { get; set; }

    /// <summary>
    /// If true, the <see cref="PacketId"/> and <see cref="PacketBuffer"/> will be passed in place of the deserialized packet model.
    /// </summary>
    public bool DirectReader { get; set; }
}