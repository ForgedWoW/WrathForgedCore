// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Scripting.Interfaces;

namespace WrathForged.Common;

public interface IConvertConfigValue : IForgedScript
{
    /// <summary>
    ///     Convert a string to another value.
    /// </summary>
    /// <param name="value"></param>
    /// <returns><see langword="null"/> or the converted object</returns>
    T? Convert<T>(string value);
}