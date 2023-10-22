// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace SSDI.Registration;

internal class InternalRegistration
{
    internal Type ExportedType { get; }
    internal FluentExportRegistration FluentExportRegistration { get; }
    internal object? Instance { get; }

    internal InternalRegistration(Type t, object? instance = null)
    {
        ExportedType = t;
        FluentExportRegistration = new FluentExportRegistration(this);
        Instance = instance;
    }
}
