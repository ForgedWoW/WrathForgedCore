// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.DBC;

[AttributeUsage(AttributeTargets.Class)]
public class DBCBoundAttribute(string name) : Attribute
{
    public string Name { get; set; } = name;
}