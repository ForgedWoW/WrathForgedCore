// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;

namespace WrathForged.Common.Scripting
{
    public class ScriptFactory
    {
        private readonly IConfiguration _configuration;

        public ScriptFactory(IConfiguration configuration)
        {
            _configuration = configuration;
            ScriptDirectory = configuration.GetDefaultValue("Scipts:Directory", ".\\Scripts");

            if (!Directory.Exists(ScriptDirectory))
                Directory.Delete(ScriptDirectory, true);
        }

        public string ScriptDirectory { get; }
    }
}