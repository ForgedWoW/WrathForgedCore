// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.DBC
{
    /// <summary>
    ///     Used for serializing DBC Models from the database to DBC Files.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DBCPropertyBindingAttribute : Attribute
    {
        public DBCPropertyBindingAttribute(uint columnIndex, DBCBindingType bindingType)
        {
            BindingType = bindingType;
            ColumnIndex = columnIndex;
        }

        public uint ColumnIndex { get; set; }
        public DBCBindingType BindingType { get; set; }

        /// <summary>
        /// ONLY SET IF IT DIFFERS FROM THE DEFAULT VALUE OF THE PROPERTY TYPE
        /// </summary>
        public object? DefaultValue { get; set; }

        /// <summary>
        ///     Used for non nullable types that can be null in the dbc such as uint or float. This will end up being empty if the value is null.
        /// </summary>
        public bool Nullable { get; set; } = false;
    }
}