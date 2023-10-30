// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.ComponentModel;
using System.Globalization;

namespace WrathForged.Models.GameMath;

/// <summary>
///     Converts a <see cref="Ray" /> to and from string representation.
/// </summary>
public class RayConverter : ExpandableObjectConverter
{
    /// <summary>
    ///     Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.
    /// </summary>
    /// <param name="context"> An <see cref="ITypeDescriptorContext" /> that provides a format context. </param>
    /// <param name="sourceType"> A <see cref="Type" /> that represents the type you want to convert from. </param>
    /// <returns> <b> true </b> if this converter can perform the conversion; otherwise, <b> false </b>. </returns>
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) => sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);

    /// <summary>
    ///     Returns whether this converter can convert the object to the specified type, using the specified context.
    /// </summary>
    /// <param name="context"> An <see cref="ITypeDescriptorContext" /> that provides a format context. </param>
    /// <param name="destinationType"> A <see cref="Type" /> that represents the type you want to convert to. </param>
    /// <returns> <b> true </b> if this converter can perform the conversion; otherwise, <b> false </b>. </returns>
    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) => destinationType == typeof(string) || base.CanConvertTo(context, destinationType);

    /// <summary>
    ///     Converts the given object to the type of this converter, using the specified context and culture information.
    /// </summary>
    /// <param name="context"> An <see cref="ITypeDescriptorContext" /> that provides a format context. </param>
    /// <param name="culture"> The <see cref="CultureInfo" /> to use as the current culture. </param>
    /// <param name="value"> The <see cref="object" /> to convert. </param>
    /// <returns> An <see cref="object" /> that represents the converted value. </returns>
    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value) => value != null && value.GetType() == typeof(string) ? Ray.Parse((string)value) : base.ConvertFrom(context, culture, value ?? default!);

    /// <summary>
    ///     Converts the given value object to the specified type, using the specified context and culture information.
    /// </summary>
    /// <param name="context"> An <see cref="ITypeDescriptorContext" /> that provides a format context. </param>
    /// <param name="culture"> A <see cref="CultureInfo" /> object. If a null reference (Nothing in Visual Basic) is passed, the current culture is assumed. </param>
    /// <param name="value"> The <see cref="object" /> to convert. </param>
    /// <param name="destinationType"> The Type to convert the <paramref name="value" /> parameter to. </param>
    /// <returns> An <see cref="object" /> that represents the converted value. </returns>
    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        return (destinationType == typeof(string)) && (value is Ray ray)
            ? ray.ToString()
            : base.ConvertTo(context, culture, value, destinationType);
    }
}
