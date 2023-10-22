// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using SSDI.Registration;

namespace WrathForged.Common.Scripting.Interfaces.CoreEvents;

public interface IRegisterDependancyInjection : IForgedScript
{
    void RegisterDependancyInjection(ExportRegistration builder, IConfiguration configuration, ILogger logger)
    {
    }
}