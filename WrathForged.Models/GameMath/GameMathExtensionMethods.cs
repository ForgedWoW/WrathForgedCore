// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using System.Text.RegularExpressions;

namespace WrathForged.Models.GameMath;

public static partial class GameMathExtensionMethods
{
    public static Vector3 Multiply(this Matrix4x4 elt, Vector3 v)
    {
        return new Vector3((elt.M11 * v.GetAt(0)) + (elt.M12 * v.GetAt(1)) + (elt.M13 * v.GetAt(2)),
                           (elt.M21 * v.GetAt(0)) + (elt.M22 * v.GetAt(1)) + (elt.M23 * v.GetAt(2)),
                           (elt.M31 * v.GetAt(0)) + (elt.M32 * v.GetAt(1)) + (elt.M33 * v.GetAt(2)));
    }

    public static void SetAt(this ref Vector3 vector, float value, long index)
    {
        switch (index)
        {
            case 0:
                vector.X = value;

                break;

            case 1:
                vector.Y = value;

                break;

            case 2:
                vector.Z = value;

                break;

            default:
                throw new IndexOutOfRangeException();
        }
    }

    public static float GetAt(this Vector3 vector, long index)
    {
        return index switch
        {
            0 => vector.X,
            1 => vector.Y,
            2 => vector.Z,
            _ => throw new IndexOutOfRangeException(),
        };
    }

    public static Vector3 ParseVector3(this string value)
    {
        var m = Vector3StringFormat().Match(value);

        return m.Success
            ? new Vector3(float.Parse(m.Result("${x}")),
                               float.Parse(m.Result("${y}")),
                               float.Parse(m.Result("${z}")))
            : throw new Exception("Unsuccessful Match for Vector3 Parse.");
    }

    [GeneratedRegex(@"\((?<x>.*),(?<y>.*),(?<z>.*)\)", RegexOptions.Singleline)]
    private static partial Regex Vector3StringFormat();
}
