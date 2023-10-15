// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.ObjectTypes;

public class FlaggableStruct<T>(T value) where T : struct
{
    private T _value = value;

    public bool IsDirty { get; set; }

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            IsDirty = true;
        }
    }
}
