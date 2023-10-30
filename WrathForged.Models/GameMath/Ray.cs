// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.ComponentModel;
using System.Numerics;
using System.Text.RegularExpressions;

namespace WrathForged.Models.GameMath;

/// <summary>
///     Represents a ray in 3D space.
/// </summary>
/// <remarks>
///     A ray is R(t) = Origin + t * Direction where t>=0. The Direction is not necessarily of unit length.
/// </remarks>
[ForgedSerializable]
[TypeConverter(typeof(RayConverter))]
public partial struct Ray : ICloneable
{
    #region Private Fields

    private static Vector3 _inf = new(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

    private Vector3 _direction;
    private Vector3 _origin;

    #endregion Private Fields

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Ray" /> class using given origin and direction vectors.
    /// </summary>
    /// <param name="origin"> Ray's origin point. </param>
    /// <param name="direction"> Ray's direction vector. </param>
    public Ray(Vector3 origin, Vector3 direction)
    {
        _origin = origin;
        _direction = direction;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Ray" /> class using given ray.
    /// </summary>
    /// <param name="ray"> A <see cref="Ray" /> instance to assign values from. </param>
    public Ray(Ray ray)
    {
        _origin = ray.Origin;
        _direction = ray.Direction;
    }

    #endregion Constructors

    #region Public Properties

    /// <summary>
    ///     Gets or sets the ray's direction vector.
    /// </summary>
    [SerializableProperty(0)]
    public Vector3 Direction
    {
        readonly get => _direction;
        set => _direction = value;
    }

    /// <summary>
    ///     Gets or sets the ray's origin.
    /// </summary>
    [SerializableProperty(1)]
    public Vector3 Origin
    {
        readonly get => _origin;
        set => _origin = value;
    }

    #endregion Public Properties

    #region ICloneable Members

    /// <summary>
    ///     Creates an exact copy of this <see cref="Ray" /> object.
    /// </summary>
    /// <returns> The <see cref="Ray" /> object this method creates, cast as an object. </returns>
    readonly object ICloneable.Clone() => new Ray(this);

    /// <summary>
    ///     Creates an exact copy of this <see cref="Ray" /> object.
    /// </summary>
    /// <returns> The <see cref="Ray" /> object this method creates. </returns>
    public readonly Ray Clone() => new(this);

    #endregion ICloneable Members

    #region Public Static Parse Methods

    /// <summary>
    ///     Converts the specified string to its <see cref="Ray" /> equivalent.
    /// </summary>
    /// <param name="s"> A string representation of a <see cref="Ray" /> </param>
    /// <returns> A <see cref="Ray" /> that represents the vector specified by the <paramref name="s" /> parameter. </returns>
    public static Ray Parse(string s)
    {
        var m = RayStringFormatRegex().Match(s);

        return m.Success
            ? new Ray(m.Result("${origin}").ParseVector3(),
                           m.Result("${direction}").ParseVector3())
            : throw new Exception("Unsuccessful Match for ray string format.");
    }

    #endregion Public Static Parse Methods

    #region Public Methods

    /// <summary>
    ///     Gets a point on the ray.
    /// </summary>
    /// <param name="t"> </param>
    /// <returns> </returns>
    public readonly Vector3 GetPointOnRay(float t) => Origin + (Direction * t);

    #endregion Public Methods

    #region Overrides

    /// <summary>
    ///     Returns a value indicating whether this instance is equal to
    ///     the specified object.
    /// </summary>
    /// <param name="obj"> An object to compare to this instance. </param>
    /// <returns> <see langword="true" /> if <paramref name="obj" /> is a <see cref="Vector3" /> and has the same values as this instance; otherwise, <see langword="false" />. </returns>
    public override readonly bool Equals(object? obj) => obj is Ray r && (_origin == r.Origin) && (_direction == r.Direction);

    /// <summary>
    ///     Get the hashcode for this instance.
    /// </summary>
    /// <returns> Returns the hash code for this vector instance. </returns>
    public override readonly int GetHashCode() => _origin.GetHashCode() ^ _direction.GetHashCode();

    /// <summary>
    ///     Returns a string representation of this object.
    /// </summary>
    /// <returns> A string representation of this object. </returns>
    public override readonly string ToString() => $"({_origin}, {_direction})";

    #endregion Overrides

    #region Comparison Operators

    /// <summary>
    ///     Tests whether two specified rays are not equal.
    /// </summary>
    /// <param name="a"> The first of two rays to compare. </param>
    /// <param name="b"> The second of two rays to compare. </param>
    /// <returns> <see langword="true" /> if the two rays are not equal; otherwise, <see langword="false" />. </returns>
    public static bool operator !=(Ray a, Ray b) => !ValueType.Equals(a, b);

    /// <summary>
    ///     Tests whether two specified rays are equal.
    /// </summary>
    /// <param name="a"> The first of two rays to compare. </param>
    /// <param name="b"> The second of two rays to compare. </param>
    /// <returns> <see langword="true" /> if the two rays are equal; otherwise, <see langword="false" />. </returns>
    public static bool operator ==(Ray a, Ray b) => ValueType.Equals(a, b);

    #endregion Comparison Operators

    public readonly Vector3 Intersection(Plane plane)
    {
        var rate = Vector3.Dot(Direction, plane.Normal);

        if (rate >= 0.0f)
        {
            return _inf;
        }
        else
        {
            var t = -(plane.D + Vector3.Dot(Origin, plane.Normal)) / rate;

            return Origin + (Direction * t);
        }
    }

    public readonly float IntersectionTime(AxisAlignedBox box)
    {
        var dummy = Vector3.Zero;
        var time = CollisionDetection.CollisionTimeForMovingPointFixedAABox(_origin, _direction, box, ref dummy, out var inside);

        return float.IsInfinity(time) && inside ? 0.0f : time;
    }

    public readonly Vector3 InvDirection() => Vector3.Divide(Vector3.One, Direction);
    [GeneratedRegex(@"\((?<origin>\([^\)]*\)), (?<direction>\([^\)]*\))\)", RegexOptions.None)]
    private static partial Regex RayStringFormatRegex();
}
