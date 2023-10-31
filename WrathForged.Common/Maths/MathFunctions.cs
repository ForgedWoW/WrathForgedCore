// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.GameMath;

namespace WrathForged.Common.Maths;

public static class MathFunctions
{
    public const float E = 2.71828f;
    public const float EPSILON = 4.76837158203125E-7f;
    public const float LOG10_E = 0.434294f;
    public const float LOG2_E = 1.4427f;
    public const float PI = 3.14159f;
    public const float PI_OVER2 = 1.5708f;
    public const float PI_OVER4 = 0.785398f;
    public const float TWO_PI = 6.28319f;

    public static float AddPct(ref float value, double pct) => value += (float)CalculatePct(value, pct);

    public static uint AddPct(ref uint value, double pct) => value += CalculatePct(value, pct);

    public static int AddPct(ref int value, double pct) => value += CalculatePct(value, pct);

    public static long AddPct(ref long value, double pct) => value += CalculatePct(value, pct);

    public static double AddPct(ref double value, double pct) => value += CalculatePct(value, pct);

    public static double AddPct(double value, double pct) => value += CalculatePct(value, pct);

    public static long AddPct(ref long value, float pct) => value += CalculatePct(value, pct);

    public static int AddPct(ref int value, float pct) => value += CalculatePct(value, pct);

    public static uint AddPct(ref uint value, float pct) => value += CalculatePct(value, pct);

    public static float AddPct(ref float value, float pct) => value += CalculatePct(value, pct);

    public static double ApplyPct(double Base, double pct) => CalculatePct(Base, pct);

    public static double ApplyPct(ref double Base, double pct) => Base = CalculatePct(Base, pct);

    public static int ApplyPct(ref int Base, double pct) => Base = CalculatePct(Base, pct);

    public static int ApplyPct(ref int Base, float pct) => Base = CalculatePct(Base, pct);

    public static uint ApplyPct(ref uint Base, float pct) => Base = CalculatePct(Base, pct);

    public static float ApplyPct(ref float Base, float pct) => Base = CalculatePct(Base, pct);

    public static void ApplyPercentModFloatVar(ref double value, double val, bool apply)
    {
        if (val == -100.0f) // prevent set var to zero
            val = -99.99f;

        value *= apply ? (100.0f + val) / 100.0f : 100.0f / (100.0f + val);
    }

    public static void ApplyPercentModFloatVar(ref float value, float val, bool apply)
    {
        if (val == -100.0f) // prevent set var to zero
            val = -99.99f;

        value *= apply ? (100.0f + val) / 100.0f : 100.0f / (100.0f + val);
    }

    public static int CalculatePct(int value, double pct) => (int)(value * (pct / 100.0f));

    public static uint CalculatePct(uint value, double pct) => (uint)(value * (pct / 100.0f));

    public static long CalculatePct(long value, double pct) => (long)(value * (pct / 100.0f));

    public static double CalculatePct(double value, double pct) => value * (pct / 100.0f);

    public static ulong CalculatePct(ulong value, double pct) => (ulong)(value * (pct / 100.0f));

    public static double CalculatePct(float value, double pct) => value * (pct / 100.0f);

    public static double CalculatePct(double value, float pct) => value * (pct / 100.0f);

    public static int CalculatePct(int value, float pct) => (int)(value * (pct / 100.0f));

    public static uint CalculatePct(uint value, float pct) => (uint)(value * (pct / 100.0f));

    public static float CalculatePct(float value, float pct) => value * (pct / 100.0f);

    public static ulong CalculatePct(ulong value, float pct) => (ulong)(value * (pct / 100.0f));

    public static long CalculatePct(long value, float pct) => (long)(value * (pct / 100.0f));

    public static bool CompareValues(ComparisonType type, uint val1, uint val2)
    {
        return type switch
        {
            ComparisonType.EQ => val1 == val2,
            ComparisonType.High => val1 > val2,
            ComparisonType.Low => val1 < val2,
            ComparisonType.HighEQ => val1 >= val2,
            ComparisonType.LowEQ => val1 <= val2,
            _ => false,// incorrect parameter
        };
    }

    public static bool CompareValues(ComparisonType type, float val1, float val2)
    {
        return type switch
        {
            ComparisonType.EQ => val1 == val2,
            ComparisonType.High => val1 > val2,
            ComparisonType.Low => val1 < val2,
            ComparisonType.HighEQ => val1 >= val2,
            ComparisonType.LowEQ => val1 <= val2,
            _ => false,// incorrect parameter
        };
    }

    public static float DegToRad(float degrees) => degrees * (2.0f * PI / 360.0f);

    public static float GetPctOf(float value, float max) => value / max * 100.0f;

    public static double GetPctOf(double value, int max) => value / max * 100.0f;

    public static int GetPctOf(int value, int max) => (int)(value / max * 100.0f);

    public static Matrix4x4 Inverse(this Matrix4x4 elt)
    {
        _ = elt.Inverse(out var kInverse);

        return kInverse;
    }

    public static bool Inverse(this Matrix4x4 elt, out Matrix4x4 rkInverse)
    {
        // Invert a 3x3 using cofactors.  This is about 8 times faster than
        // the Numerical Recipes code which uses Gaussian elimination.
        rkInverse = new Matrix4x4
        {
            M11 = (elt.M22 * elt.M33) -
                        (elt.M23 * elt.M32),

            M12 = (elt.M13 * elt.M32) -
                        (elt.M12 * elt.M33),

            M13 = (elt.M12 * elt.M23) -
                        (elt.M13 * elt.M22),

            M21 = (elt.M23 * elt.M31) -
                        (elt.M21 * elt.M33),

            M22 = (elt.M11 * elt.M33) -
                        (elt.M13 * elt.M31),

            M23 = (elt.M13 * elt.M21) -
                        (elt.M11 * elt.M23),

            M31 = (elt.M21 * elt.M32) -
                        (elt.M22 * elt.M31),

            M32 = (elt.M12 * elt.M31) -
                        (elt.M11 * elt.M32),

            M33 = (elt.M11 * elt.M22) -
                        (elt.M12 * elt.M21)
        };

        var fDet =
            (elt.M11 * rkInverse.M11) +
            (elt.M12 * rkInverse.M21) +
            (elt.M13 * rkInverse.M31);

        if (Math.Abs(fDet) <= float.Epsilon)
            return false;

        var fInvDet = 1.0f / fDet;

        rkInverse.M11 *= fInvDet;
        rkInverse.M12 *= fInvDet;
        rkInverse.M13 *= fInvDet;
        rkInverse.M21 *= fInvDet;
        rkInverse.M22 *= fInvDet;
        rkInverse.M23 *= fInvDet;
        rkInverse.M31 *= fInvDet;
        rkInverse.M32 *= fInvDet;
        rkInverse.M33 *= fInvDet;

        return true;
    }

    public static float Lerp(float a, float b, float f) => a + ((b - a) * f);

    public static ushort MakePair16(uint l, uint h) => (ushort)((byte)l | ((ushort)h << 8));

    public static uint MakePair32(uint l, uint h) => (ushort)l | (h << 16);

    public static ulong MakePair64(uint l, uint h) => l | ((ulong)h << 32);

    public static ushort Pair32_HiPart(uint x) => (ushort)((x >> 16) & 0x0000FFFF);

    public static ushort Pair32_LoPart(uint x) => (ushort)(x & 0x0000FFFF);

    public static uint Pair64_HiPart(ulong x) => (uint)((x >> 32) & 0x00000000FFFFFFFF);

    public static uint Pair64_LoPart(ulong x) => (uint)(x & 0x00000000FFFFFFFF);

    public static int RoundToInterval(ref int num, dynamic floor, dynamic ceil) => num = (int)Math.Min(Math.Max(num, floor), ceil);

    public static uint RoundToInterval(ref uint num, dynamic floor, dynamic ceil) => num = Math.Min(Math.Max(num, floor), ceil);

    public static float RoundToInterval(ref float num, dynamic floor, dynamic ceil) => num = Math.Min(Math.Max(num, floor), ceil);

    public static double RoundToInterval(ref double num, dynamic floor, dynamic ceil) => num = Math.Min(Math.Max(num, floor), ceil);

    public static void Swap<T>(ref T lhs, ref T rhs) => (lhs, rhs) = (rhs, lhs);

    public static Matrix4x4 ToMatrix(this Quaternion _q)
    {
        // Implementation from Watt and Watt, pg 362
        // See also http://www.flipcode.com/documents/matrfaq.html#Q54
        var q = _q;
        q *= 1.0f / MathF.Sqrt((q.X * q.X) + (q.Y * q.Y) + (q.Z * q.Z) + (q.W * q.W));

        var xx = 2.0f * q.X * q.X;
        var xy = 2.0f * q.X * q.Y;
        var xz = 2.0f * q.X * q.Z;
        var xw = 2.0f * q.X * q.W;

        var yy = 2.0f * q.Y * q.Y;
        var yz = 2.0f * q.Y * q.Z;
        var yw = 2.0f * q.Y * q.W;

        var zz = 2.0f * q.Z * q.Z;
        var zw = 2.0f * q.Z * q.W;

        return new Matrix4x4(1.0f - yy - zz,
                             xy - zw,
                             xz + yw,
                             0.0f,
                             xy + zw,
                             1.0f - xx - zz,
                             yz - xw,
                             0.0f,
                             xz - yw,
                             yz + xw,
                             1.0f - xx - yy,
                             0.0f,
                             0.0f,
                             0.0f,
                             0.0f,
                             1.0f);
    }

    //3d math
    public static Box ToWorldSpace(Matrix4x4 rotation, Vector3 translation, Box box)
    {
        if (!box.IsFinite())
            return box;

        var outBox = box;

        outBox.Center = new Vector3((rotation.M11 * box.Center.GetAt(0)) + (rotation.M12 * box.Center.GetAt(1)) + (rotation.M13 * box.Center.GetAt(2)) + translation.GetAt(0),
                                     (rotation.M21 * box.Center.GetAt(0)) + (rotation.M22 * box.Center.GetAt(1)) + (rotation.M23 * box.Center.GetAt(2)) + translation.GetAt(1),
                                     (rotation.M31 * box.Center.GetAt(0)) + (rotation.M32 * box.Center.GetAt(1)) + (rotation.M33 * box.Center.GetAt(2)) + translation.GetAt(2));

        for (var i = 0; i < 3; ++i)
            outBox.EdgeVector[i] = rotation.Multiply(box.EdgeVector[i]);

        outBox.Area = box.Area;
        outBox.Volume = box.Volume;

        return box;
    }

    public static double Variance(this IEnumerable<uint> source)
    {
        var n = 0;
        double mean = 0;
        double M2 = 0;

        foreach (var x in source)
        {
            n++;
            var delta = x - mean;
            mean += delta / n;
            M2 += delta * (x - mean);
        }

        return M2 / (n - 1);
    }

    public static float Wrap(float t, float lo, float hi)
    {
        if ((t >= lo) && (t < hi))
            return t;

        var interval = hi - lo;

        return (float)(t - (interval * Math.Floor((t - lo) / interval)));
    }

    private static double EPS(double a)
    {
        var aa = Math.Abs(a) + 1.0f;

        return double.IsPositiveInfinity(aa) ? (double)0.0000005f : 0.0000005f * aa;
    }

    private static double EPS(float a)
    {
        var aa = Math.Abs(a) + 1.0f;

        return float.IsPositiveInfinity(aa) ? (double)0.0000005f : 0.0000005f * aa;
    }

    #region Clamp

    /// <summary>
    ///     Clamp a <paramref name="value" /> to <paramref name="calmpedValue" /> if it is withon the <paramref name="tolerance" /> range.
    /// </summary>
    /// <param name="value"> The value to clamp. </param>
    /// <param name="calmpedValue"> The clamped value. </param>
    /// <param name="tolerance"> The tolerance value. </param>
    /// <returns>
    ///     Returns the clamped value.
    ///     result = (tolerance > Abs(value-calmpedValue)) ? calmpedValue : value;
    /// </returns>
    public static float Clamp(float value, float calmpedValue, float tolerance) => (tolerance > Math.Abs(value - calmpedValue)) ? calmpedValue : value;

    /// <summary>
    ///     Clamp a <paramref name="value" /> to <paramref name="calmpedValue" /> using the default tolerance value.
    /// </summary>
    /// <param name="value"> The value to clamp. </param>
    /// <param name="calmpedValue"> The clamped value. </param>
    /// <returns>
    ///     Returns the clamped value.
    ///     result = (EpsilonF > Abs(value-calmpedValue)) ? calmpedValue : value;
    /// </returns>
    /// <remarks> <see cref="EPSILON" /> is used for tolerance. </remarks>
    public static float Clamp(float value, float calmpedValue) => (EPSILON > Math.Abs(value - calmpedValue)) ? calmpedValue : value;

    #endregion Clamp

    #region Fuzzy

    public static bool FuzzyEq(double a, double b) => (a == b) || (Math.Abs(a - b) <= EPS(a));

    public static bool FuzzyEq(float a, float b) => (a == b) || (Math.Abs(a - b) <= EPS(a));

    public static bool FuzzyGe(float a, float b) => a > b - EPS(a);

    public static bool FuzzyGt(float a, float b) => a > b + EPS(a);

    public static bool FuzzyLe(float a, float b) => a < b + EPS(a);

    public static bool FuzzyLe(double a, double b) => a < b + EPS(a);

    public static bool FuzzyLt(float a, float b) => a < b - EPS(a);

    public static bool FuzzyNe(float a, float b) => !FuzzyEq(a, b);

    #endregion Fuzzy

    public static Matrix4x4 FromEulerAnglesZYX(float fYAngle, float fPAngle, float fRAngle)
    {
        var fCos = MathF.Cos(fYAngle);
        var fSin = MathF.Sin(fYAngle);
        Matrix4x4 kZMat = new(fCos, -fSin, 0.0f, 0.0f, fSin, fCos, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);

        fCos = MathF.Cos(fPAngle);
        fSin = MathF.Sin(fPAngle);
        Matrix4x4 kYMat = new(fCos, 0.0f, fSin, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, -fSin, 0.0f, fCos, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);

        fCos = MathF.Cos(fRAngle);
        fSin = MathF.Sin(fRAngle);
        Matrix4x4 kXMat = new(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, fCos, -fSin, 0.0f, 0.0f, fSin, fCos, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);

        return kZMat * (kYMat * kXMat);
    }
}
