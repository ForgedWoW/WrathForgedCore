﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using System.Runtime.Serialization;

namespace WrathForged.Models.GameMath;

/// <summary>
///     Represents an axis aligned box in 3D space.
/// </summary>
/// <remarks>
///     An axis-aligned box is a box whose faces coincide with the standard basis axes.
/// </remarks>
[ForgedSerializable]
public class AxisAlignedBox : ISerializable, ICloneable
{
    #region Private Fields

    private Vector3 _hi;
    private Vector3 _lo;

    #endregion Private Fields

    #region Constructors

    public AxisAlignedBox()
    {
        _lo = Vector3.Zero;
        _hi = Vector3.Zero;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AxisAlignedBox" /> class using given minimum and maximum points.
    /// </summary>
    /// <param name="min"> A <see cref="Vector3" /> instance representing the minimum point. </param>
    /// <param name="max"> A <see cref="Vector3" /> instance representing the maximum point. </param>
    public AxisAlignedBox(Vector3 min, Vector3 max)
    {
        _lo = min;
        _hi = max;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AxisAlignedBox" /> class using given values from another box instance.
    /// </summary>
    /// <param name="box"> A <see cref="AxisAlignedBox" /> instance to take values from. </param>
    public AxisAlignedBox(AxisAlignedBox box)
    {
        _lo = box.Lo;
        _hi = box.Hi;
    }

    #endregion Constructors

    #region Public Properties

    /// <summary>
    ///     Gets or sets the maximum point which is the box's maximum X and Y coordinates.
    /// </summary>
    [SerializableProperty(0)]
    public Vector3 Hi
    {
        get => _hi;
        set => _hi = value;
    }

    /// <summary>
    ///     Gets or sets the minimum point which is the box's minimum X and Y coordinates.
    /// </summary>
    [SerializableProperty(1)]
    public Vector3 Lo
    {
        get => _lo;
        set => _lo = value;
    }

    #endregion Public Properties

    #region ISerializable Members

    /// <summary>
    ///     Populates a <see cref="SerializationInfo" /> with the data needed to serialize the target object.
    /// </summary>
    /// <param name="info"> The <see cref="SerializationInfo" /> to populate with data. </param>
    /// <param name="context"> The destination (see <see cref="StreamingContext" />) for this serialization. </param>
    //[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Max", _hi, typeof(Vector3));
        info.AddValue("Min", _lo, typeof(Vector3));
    }

    #endregion ISerializable Members

    #region ICloneable Members

    /// <summary>
    ///     Creates an exact copy of this <see cref="AxisAlignedBox" /> object.
    /// </summary>
    /// <returns> The <see cref="AxisAlignedBox" /> object this method creates, cast as an object. </returns>
    object ICloneable.Clone() => new AxisAlignedBox(this);

    /// <summary>
    ///     Creates an exact copy of this <see cref="AxisAlignedBox" /> object.
    /// </summary>
    /// <returns> The <see cref="AxisAlignedBox" /> object this method creates. </returns>
    public AxisAlignedBox Clone() => new(this);

    #endregion ICloneable Members

    #region Public Methods

    /// <summary>
    ///     Computes the box vertices.
    /// </summary>
    /// <returns> An array of <see cref="Vector3" /> containing the box vertices. </returns>
    public Vector3[] ComputeVertices()
    {
        var vertices = new Vector3[8];

        vertices[0] = _lo;
        vertices[1] = new Vector3(_hi.X, _lo.Y, _lo.Z);
        vertices[2] = new Vector3(_hi.X, _hi.Y, _lo.Z);
        vertices[3] = new Vector3(_lo.X, _hi.Y, _lo.Z);

        vertices[4] = new Vector3(_lo.X, _lo.Y, _hi.Z);
        vertices[5] = new Vector3(_hi.X, _lo.Y, _hi.Z);
        vertices[6] = _hi;
        vertices[7] = new Vector3(_lo.X, _hi.Y, _hi.Z);

        return vertices;
    }

    #endregion Public Methods

    #region Overrides

    /// <summary>
    ///     Returns a value indicating whether this instance is equal to
    ///     the specified object.
    /// </summary>
    /// <param name="obj"> An object to compare to this instance. </param>
    /// <returns> True if <paramref name="obj" /> is a <see cref="Vector3" /> and has the same values as this instance; otherwise, False. </returns>
    public override bool Equals(object? obj) => obj is AxisAlignedBox box && (_lo == box.Lo) && (_hi == box.Hi);

    /// <summary>
    ///     Returns the hashcode for this instance.
    /// </summary>
    /// <returns> A 32-bit signed integer hash code. </returns>
    public override int GetHashCode() => _lo.GetHashCode() ^ _hi.GetHashCode();

    /// <summary>
    ///     Returns a string representation of this object.
    /// </summary>
    /// <returns> A string representation of this object. </returns>
    public override string ToString() => $"AxisAlignedBox(Min={_lo}, Max={_hi})";

    #endregion Overrides

    #region Comparison Operators

    /// <summary>
    ///     Checks if the two given boxes are not equal.
    /// </summary>
    /// <param name="a"> The first of two boxes to compare. </param>
    /// <param name="b"> The second of two boxes to compare. </param>
    /// <returns> <b> true </b> if the vectors are not equal; otherwise, <b> false </b>. </returns>
    public static bool operator !=(AxisAlignedBox a, AxisAlignedBox b)
    {
        if (Equals(a, null) == true)
            return !Equals(b, null);
        else if (Equals(b, null) == true)
            return !Equals(a, null);

        return !((a.Lo == b.Lo) && (a.Hi == b.Hi));
    }

    /// <summary>
    ///     Checks if the two given boxes are equal.
    /// </summary>
    /// <param name="a"> The first of two boxes to compare. </param>
    /// <param name="b"> The second of two boxes to compare. </param>
    /// <returns> <b> true </b> if the boxes are equal; otherwise, <b> false </b>. </returns>
    public static bool operator ==(AxisAlignedBox a, AxisAlignedBox b) => Equals(a, null) ? Equals(b, null) : Equals(b, null) ? Equals(a, null) : (a.Lo == b.Lo) && (a.Hi == b.Hi);

    #endregion Comparison Operators

    public static AxisAlignedBox operator +(AxisAlignedBox box, Vector3 v)
    {
        return new()
        {
            Lo = box.Lo + v,
            Hi = box.Hi + v
        };
    }

    public static AxisAlignedBox Zero() => new(Vector3.Zero, Vector3.Zero);

    public bool Contains(Vector3 point)
    {
        return
            (point.X >= _lo.X) &&
            (point.Y >= _lo.Y) &&
            (point.Z >= _lo.Z) &&
            (point.X <= _hi.X) &&
            (point.Y <= _hi.Y) &&
            (point.Z <= _hi.Z);
    }

    public Vector3 Corner(int index)
    {
        // default constructor inits all components to 0
        Vector3 v = new();

        switch (index)
        {
            case 0:
                v.X = _lo.X;
                v.Y = _lo.Y;
                v.Z = _hi.Z;

                break;

            case 1:
                v.X = _hi.X;
                v.Y = _lo.Y;
                v.Z = _hi.Z;

                break;

            case 2:
                v.X = _hi.X;
                v.Y = _hi.Y;
                v.Z = _hi.Z;

                break;

            case 3:
                v.X = _lo.X;
                v.Y = _hi.Y;
                v.Z = _hi.Z;

                break;

            case 4:
                v.X = _lo.X;
                v.Y = _lo.Y;
                v.Z = _lo.Z;

                break;

            case 5:
                v.X = _hi.X;
                v.Y = _lo.Y;
                v.Z = _lo.Z;

                break;

            case 6:
                v.X = _hi.X;
                v.Y = _hi.Y;
                v.Z = _lo.Z;

                break;

            case 7:
                v.X = _lo.X;
                v.Y = _hi.Y;
                v.Z = _lo.Z;

                break;

        }

        return v;
    }

    public void Merge(AxisAlignedBox a)
    {
        Lo = Vector3.Min(_lo, a.Lo);
        Hi = Vector3.Max(Hi, a.Hi);
    }

    public void Merge(Vector3 a)
    {
        _lo = Vector3.Min(_lo, a);
        _hi = Vector3.Max(_hi, a);
    }
}