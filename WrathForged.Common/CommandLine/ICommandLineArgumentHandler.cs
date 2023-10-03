// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;

using WrathForged.Common.Scripting.Interfaces;

namespace WrathForged.Common.CommandLine;

public interface ICommandLineArgumentHandler : IForgedScript
{
    Command AddCommand();
}