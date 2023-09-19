// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Grace.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace WrathForged.Common
{
    public interface IRegisterDependancyInjection
    {
        void RegisterDependancyInjection(IExportRegistrationBlock builder, IConfiguration configuration, ILogger logger)
        {
        }
    }
}