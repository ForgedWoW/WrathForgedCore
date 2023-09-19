// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Common.DBC
{
    public class Binding
    {
        public readonly BindingEntry[] Fields;
        public readonly string Name;
        public readonly bool OrderOutput;

        public Binding(string fileName, List<BindingEntry> bindingEntryList, bool orderOutput)
        {
            Name = Path.GetFileNameWithoutExtension(fileName);
            Fields = bindingEntryList.ToArray();
            OrderOutput = orderOutput;
        }

        /**
         * Calculates and returns the size of the structure represented by this binding.
         */

        public int CalcRecordSize()
        {
            var size = 0;
            foreach (var field in Fields)
            {
                switch (field.Type)
                {
                    case DBCBindingType.INT32:
                    {
                        size += sizeof(int);
                        break;
                    }
                    case DBCBindingType.STRING:
                    case DBCBindingType.UINT32:
                    {
                        size += sizeof(uint);
                        break;
                    }
                    case DBCBindingType.UINT8:
                    {
                        size += sizeof(byte);
                        break;
                    }
                    case DBCBindingType.FLOAT:
                    {
                        size += sizeof(float);
                        break;
                    }
                    case DBCBindingType.DOUBLE:
                    {
                        size += sizeof(double);
                        break;
                    }
                }
            }

            return size;
        }

        /**
         * Calculates and returns the number of fields the structure represented by this binding contains.
         */

        public int CalcFieldCount() => Fields == null ? 0 : Fields.Length;

        /**
         * Returns the number of rows in the database for the given binding/table name.
         *
         * Returns -1 if an exception is raised, most likely because the table does not exist.
         *
         * A better way to query for the table existing would be to query the performance_schema,
         * but this requires more permissions for a MySQL user.
         */

        public override string ToString() => $"{Name}${GetHashCode()}";
    }
}