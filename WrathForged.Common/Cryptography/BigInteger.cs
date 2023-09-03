// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace WrathForged.Common.Cryptography
{
    [Serializable]
    public partial class BigInteger : ISerializable
    {
        /// <summary>
        /// Maximum length of the BigInteger in uint. (4 bytes)
        /// </summary>
        /// <remarks>Change this to suit the required level of precision.</remarks>
        private const int MAX_LENGTH = 70;

        /// <summary>
        /// Primes smaller than 2000 to test the generated prime number.
        /// </summary>
        public static int[] PrimesBelow2000 { get; } = {
                                                           2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53,
                                                           59, 61, 67, 71, 73, 79, 83, 89, 97,
                                                           101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157,
                                                           163, 167, 173, 179, 181, 191, 193, 197, 199,
                                                           211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271,
                                                           277, 281, 283, 293,
                                                           307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373,
                                                           379, 383, 389, 397,
                                                           401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463,
                                                           467, 479, 487, 491, 499,
                                                           503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587,
                                                           593, 599,
                                                           601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661,
                                                           673, 677, 683, 691,
                                                           701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773,
                                                           787, 797,
                                                           809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877,
                                                           881, 883, 887,
                                                           907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983,
                                                           991, 997,
                                                           1009, 1013, 1019, 1021, 1031, 1033, 1039, 1049, 1051, 1061,
                                                           1063, 1069, 1087, 1091, 1093, 1097,
                                                           1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181,
                                                           1187, 1193,
                                                           1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277,
                                                           1279, 1283, 1289, 1291, 1297,
                                                           1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381,
                                                           1399,
                                                           1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459,
                                                           1471, 1481, 1483, 1487, 1489, 1493, 1499,
                                                           1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579,
                                                           1583, 1597,
                                                           1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663,
                                                           1667, 1669, 1693, 1697, 1699,
                                                           1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783,
                                                           1787, 1789,
                                                           1801, 1811, 1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877,
                                                           1879, 1889,
                                                           1901, 1907, 1913, 1931, 1933, 1949, 1951, 1973, 1979, 1987,
                                                           1993, 1997, 1999
                                                       };

        /// <summary>
        /// Holds bytes from the BigInteger.
        /// </summary>
        private uint[] _data;

        public int DataLength { get; set; } // number of actual chars used

        #region Constructors

        //***********************************************************************
        // Constructor (Default value for BigInteger is 0
        //***********************************************************************

        public BigInteger()
        {
            _data = new uint[MAX_LENGTH];
            DataLength = 1;
        }

        //***********************************************************************
        // Constructor (Default value provided by long)
        //***********************************************************************

        public BigInteger(long value)
        {
            _data = new uint[MAX_LENGTH];
            var tempVal = value;

            // copy bytes from long to BigInteger without any assumption of
            // the length of the long datatype

            DataLength = 0;
            while (value != 0 && DataLength < MAX_LENGTH)
            {
                _data[DataLength] = (uint)(value & 0xFFFFFFFF);
                value >>= 32;
                DataLength++;
            }

            if (tempVal > 0) // overflow check for +ve value
            {
                if (value != 0 || (_data[MAX_LENGTH - 1] & 0x80000000) != 0)
                    throw (new ArithmeticException("Positive overflow in constructor."));
            }
            else if (tempVal < 0) // underflow check for -ve value
            {
                if (value != -1 || (_data[DataLength - 1] & 0x80000000) == 0)
                    throw (new ArithmeticException("Negative underflow in constructor."));
            }

            if (DataLength == 0)
                DataLength = 1;
        }

        //***********************************************************************
        // Constructor (Default value provided by ulong)
        //***********************************************************************

        public BigInteger(ulong value)
        {
            _data = new uint[MAX_LENGTH];

            // copy bytes from ulong to BigInteger without any assumption of
            // the length of the ulong datatype

            DataLength = 0;
            while (value != 0 && DataLength < MAX_LENGTH)
            {
                _data[DataLength] = (uint)(value & 0xFFFFFFFF);
                value >>= 32;
                DataLength++;
            }

            if (value != 0 || (_data[MAX_LENGTH - 1] & 0x80000000) != 0)
                throw (new ArithmeticException("Positive overflow in constructor."));

            if (DataLength == 0)
                DataLength = 1;
        }

        //***********************************************************************
        // Constructor (Default value provided by BigInteger)
        //***********************************************************************

        public BigInteger(BigInteger bi)
        {
            SetValue(bi);
        }

        public void SetValue(BigInteger bi)
        {
            _data = new uint[MAX_LENGTH];

            DataLength = bi.DataLength;

            for (var i = 0; i < DataLength; i++)
                _data[i] = bi._data[i];
        }

        //***********************************************************************
        // Constructor (Default value provided by a string of digits of the
        //              specified base)
        //
        // Example (base 10)
        // -----------------
        // To initialize "a" with the default value of 1234 in base 10
        //      BigInteger a = new BigInteger("1234", 10)
        //
        // To initialize "a" with the default value of -1234
        //      BigInteger a = new BigInteger("-1234", 10)
        //
        // Example (base 16)
        // -----------------
        // To initialize "a" with the default value of 0x1D4F in base 16
        //      BigInteger a = new BigInteger("1D4F", 16)
        //
        // To initialize "a" with the default value of -0x1D4F
        //      BigInteger a = new BigInteger("-1D4F", 16)
        //
        // Note that string values are specified in the <sign><magnitude>
        // format.
        //
        //***********************************************************************

        public BigInteger(string value, int radix)
        {
            var multiplier = new BigInteger(1);
            var result = new BigInteger();
            value = (value.ToUpper()).Trim();
            var limit = 0;

            if (value[0] == '-')
                limit = 1;

            for (var i = value.Length - 1; i >= limit; i--)
            {
                int posVal = value[i];

                if (posVal >= '0' && posVal <= '9')
                    posVal -= '0';
                else if (posVal >= 'A' && posVal <= 'Z')
                    posVal = (posVal - 'A') + 10;
                else
                    posVal = 9999999; // arbitrary large

                if (posVal >= radix)
                    throw (new ArithmeticException("Invalid string in constructor."));
                else
                {
                    if (value[0] == '-')
                        posVal = -posVal;

                    result = result + (multiplier * posVal);

                    if ((i - 1) >= limit)
                        multiplier = multiplier * radix;
                }
            }

            if (value[0] == '-') // negative values
            {
                if ((result._data[MAX_LENGTH - 1] & 0x80000000) == 0)
                    throw (new ArithmeticException("Negative underflow in constructor."));
            }
            else // positive values
            {
                if ((result._data[MAX_LENGTH - 1] & 0x80000000) != 0)
                    throw (new ArithmeticException("Positive overflow in constructor."));
            }

            _data = new uint[MAX_LENGTH];
            for (var i = 0; i < result.DataLength; i++)
                _data[i] = result._data[i];

            DataLength = result.DataLength;
        }

        //***********************************************************************
        // Constructor (Default value provided by an array of bytes)
        //
        // The lowest index of the input byte array (i.e [0]) should contain the
        // most significant byte of the number, and the highest index should
        // contain the least significant byte.
        //
        // E.g.
        // To initialize "a" with the default value of 0x1D4F in base 16
        //      byte[] temp = { 0x1D, 0x4F };
        //      BigInteger a = new BigInteger(temp)
        //
        // Note that this method of initialization does not allow the
        // sign to be specified.
        //
        //***********************************************************************

        public BigInteger(byte[] inData)
        {
            // copy the array, or people will be confused about why their array is suddenly reversed
            inData = (byte[])inData.Clone();

            Reverse(inData);
            DataLength = inData.Length >> 2;

            var leftOver = inData.Length & 0x3;
            if (leftOver != 0) // length not multiples of 4
                DataLength++;

            if (DataLength > MAX_LENGTH)
                throw (new ArithmeticException("Byte overflow in constructor."));

            _data = new uint[MAX_LENGTH];

            for (int i = inData.Length - 1, j = 0; i >= 3; i -= 4, j++)
            {
                _data[j] = (uint)((inData[i - 3] << 24) + (inData[i - 2] << 16) +
                                  (inData[i - 1] << 8) + inData[i]);
            }

            switch (leftOver)
            {
                case 1:
                    _data[DataLength - 1] = inData[0];
                    break;

                case 2:
                    _data[DataLength - 1] = (uint)((inData[0] << 8) + inData[1]);
                    break;

                case 3:
                    _data[DataLength - 1] = (uint)((inData[0] << 16) + (inData[1] << 8) + inData[2]);
                    break;
            }

            while (DataLength > 1 && _data[DataLength - 1] == 0)
                DataLength--;

            //Console.WriteLine("Len = " + dataLength);
        }

        //***********************************************************************
        // Constructor (Default value provided by an array of bytes of the
        // specified length.)
        //***********************************************************************

        public BigInteger(byte[] inData, int inLen)
        {
            DataLength = inLen >> 2;

            var leftOver = inLen & 0x3;
            if (leftOver != 0) // length not multiples of 4
                DataLength++;

            if (DataLength > MAX_LENGTH || inLen > inData.Length)
                throw (new ArithmeticException("Byte overflow in constructor."));

            _data = new uint[MAX_LENGTH];

            for (int i = inLen - 1, j = 0; i >= 3; i -= 4, j++)
            {
                _data[j] = (uint)((inData[i - 3] << 24) + (inData[i - 2] << 16) +
                                  (inData[i - 1] << 8) + inData[i]);
            }

            if (leftOver == 1)
                _data[DataLength - 1] = inData[0];
            else if (leftOver == 2)
                _data[DataLength - 1] = (uint)((inData[0] << 8) + inData[1]);
            else if (leftOver == 3)
                _data[DataLength - 1] = (uint)((inData[0] << 16) + (inData[1] << 8) + inData[2]);

            if (DataLength == 0)
                DataLength = 1;

            while (DataLength > 1 && _data[DataLength - 1] == 0)
                DataLength--;

            //Console.WriteLine("Len = " + dataLength);
        }

        //***********************************************************************
        // Constructor (Default value provided by an array of unsigned integers)
        //*********************************************************************

        public BigInteger(uint[] inData)
        {
            DataLength = inData.Length;

            if (DataLength > MAX_LENGTH)
                throw (new ArithmeticException("Byte overflow in constructor."));

            _data = new uint[MAX_LENGTH];

            for (int i = DataLength - 1, j = 0; i >= 0; i--, j++)
                _data[j] = inData[i];

            while (DataLength > 1 && _data[DataLength - 1] == 0)
                DataLength--;

            //Console.WriteLine("Len = " + dataLength);
        }

        public BigInteger(Random rand, int bitLength)
        {
            _data = new uint[MAX_LENGTH];
            DataLength = 1;

            GenerateRandomBits(bitLength, rand);
        }

        #endregion Constructors

        #region Overloading of the typecast operator.

        // For BigInteger bi = 10;
        //***********************************************************************

        public static explicit operator BigInteger(long value)
        {
            return (new BigInteger(value));
        }

        public static explicit operator BigInteger(ulong value)
        {
            return (new BigInteger(value));
        }

        public static explicit operator BigInteger(int value)
        {
            return (new BigInteger(value));
        }

        public static explicit operator BigInteger(uint value)
        {
            return (new BigInteger((ulong)value));
        }

        public static implicit operator BigInteger(byte[] value)
        {
            return (new BigInteger(value));
        }

        #endregion Overloading of the typecast operator.

        #region Overloading of add, subtract operators

        public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
        {
            var result = new BigInteger();

            result.DataLength = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;

            long carry = 0;
            for (var i = 0; i < result.DataLength; i++)
            {
                var sum = bi1._data[i] + (long)bi2._data[i] + carry;
                carry = sum >> 32;
                result._data[i] = (uint)(sum & 0xFFFFFFFF);
            }

            if (carry != 0 && result.DataLength < MAX_LENGTH)
            {
                result._data[result.DataLength] = (uint)(carry);
                result.DataLength++;
            }

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            // overflow check
            var lastPos = MAX_LENGTH - 1;
            if ((bi1._data[lastPos] & 0x80000000) == (bi2._data[lastPos] & 0x80000000) &&
                (result._data[lastPos] & 0x80000000) != (bi1._data[lastPos] & 0x80000000))
            {
                throw (new ArithmeticException());
            }

            return result;
        }

        public static BigInteger operator +(BigInteger bi1, long bi2)
        {
            return bi1 + (BigInteger)bi2;
        }

        public static BigInteger operator +(BigInteger bi1, ulong bi2)
        {
            return bi1 + (BigInteger)bi2;
        }

        public static BigInteger operator +(BigInteger bi1, int bi2)
        {
            return bi1 + (BigInteger)bi2;
        }

        public static BigInteger operator +(BigInteger bi1, uint bi2)
        {
            return bi1 + (BigInteger)bi2;
        }

        //***********************************************************************
        // Overloading of the unary ++ operator
        //***********************************************************************

        public static BigInteger operator ++(BigInteger bi1)
        {
            var result = new BigInteger(bi1);

            long carry = 1;
            var index = 0;

            while (carry != 0 && index < MAX_LENGTH)
            {
                long val;
                val = result._data[index];
                val++;

                result._data[index] = (uint)(val & 0xFFFFFFFF);
                carry = val >> 32;

                index++;
            }

            if (index > result.DataLength)
                result.DataLength = index;
            else
            {
                while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                    result.DataLength--;
            }

            // overflow check
            var lastPos = MAX_LENGTH - 1;

            // overflow if initial value was +ve but ++ caused a sign
            // change to negative.

            if ((bi1._data[lastPos] & 0x80000000) == 0 &&
                (result._data[lastPos] & 0x80000000) != (bi1._data[lastPos] & 0x80000000))
            {
                throw (new ArithmeticException("Overflow in ++."));
            }

            return result;
        }

        //***********************************************************************
        // Overloading of the NEGATE operator (2's complement)
        //***********************************************************************

        public static BigInteger operator -(BigInteger bi1)
        {
            // handle neg of zero separately since it'll cause an overflow
            // if we proceed.

            if (bi1.DataLength == 1 && bi1._data[0] == 0)
                return (new BigInteger());

            var result = new BigInteger(bi1);

            // 1's complement
            for (var i = 0; i < MAX_LENGTH; i++)
                result._data[i] = ~(bi1._data[i]);

            // add one to result of 1's complement
            long carry = 1;
            var index = 0;

            while (carry != 0 && index < MAX_LENGTH)
            {
                long val;
                val = result._data[index];
                val++;

                result._data[index] = (uint)(val & 0xFFFFFFFF);
                carry = val >> 32;

                index++;
            }

            if ((bi1._data[MAX_LENGTH - 1] & 0x80000000) == (result._data[MAX_LENGTH - 1] & 0x80000000))
                throw (new ArithmeticException("Overflow in negation.\n"));

            result.DataLength = MAX_LENGTH;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;
            return result;
        }

        //***********************************************************************
        // Overloading of subtraction operator
        //***********************************************************************

        public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
        {
            var result = new BigInteger();

            result.DataLength = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;

            long carryIn = 0;
            for (var i = 0; i < result.DataLength; i++)
            {
                long diff;

                diff = bi1._data[i] - (long)bi2._data[i] - carryIn;
                result._data[i] = (uint)(diff & 0xFFFFFFFF);

                if (diff < 0)
                    carryIn = 1;
                else
                    carryIn = 0;
            }

            // roll over to negative
            if (carryIn != 0)
            {
                for (var i = result.DataLength; i < MAX_LENGTH; i++)
                    result._data[i] = 0xFFFFFFFF;
                result.DataLength = MAX_LENGTH;
            }

            // fixed in v1.03 to give correct datalength for a - (-b)
            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            // overflow check

            var lastPos = MAX_LENGTH - 1;
            if ((bi1._data[lastPos] & 0x80000000) != (bi2._data[lastPos] & 0x80000000) &&
                (result._data[lastPos] & 0x80000000) != (bi1._data[lastPos] & 0x80000000))
            {
                throw (new ArithmeticException());
            }

            return result;
        }

        public static BigInteger operator -(BigInteger bi1, long bi2)
        {
            return bi1 - (BigInteger)bi2;
        }

        public static BigInteger operator -(BigInteger bi1, ulong bi2)
        {
            return bi1 - (BigInteger)bi2;
        }

        public static BigInteger operator -(BigInteger bi1, int bi2)
        {
            return bi1 - (BigInteger)bi2;
        }

        public static BigInteger operator -(BigInteger bi1, uint bi2)
        {
            return bi1 - (BigInteger)bi2;
        }

        //***********************************************************************
        // Overloading of the unary -- operator
        //***********************************************************************

        public static BigInteger operator --(BigInteger bi1)
        {
            var result = new BigInteger(bi1);

            var carryIn = true;
            var index = 0;

            while (carryIn && index < MAX_LENGTH)
            {
                long val;
                val = result._data[index];
                val--;

                result._data[index] = (uint)(val & 0xFFFFFFFF);

                if (val >= 0)
                    carryIn = false;

                index++;
            }

            if (index > result.DataLength)
                result.DataLength = index;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            // overflow check
            var lastPos = MAX_LENGTH - 1;

            // overflow if initial value was -ve but -- caused a sign
            // change to positive.

            if ((bi1._data[lastPos] & 0x80000000) != 0 &&
                (result._data[lastPos] & 0x80000000) != (bi1._data[lastPos] & 0x80000000))
            {
                throw (new ArithmeticException("Underflow in --."));
            }

            return result;
        }

        #endregion Overloading of add, subtract operators

        #region Overloading of multiplication, division and modulus

        public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
        {
            var lastPos = MAX_LENGTH - 1;
            bool bi1Neg = false, bi2Neg = false;

            // take the absolute value of the inputs
            try
            {
                if ((bi1._data[lastPos] & 0x80000000) != 0) // bi1 negative
                {
                    bi1Neg = true;
                    bi1 = -bi1;
                }

                if ((bi2._data[lastPos] & 0x80000000) != 0) // bi2 negative
                {
                    bi2Neg = true;
                    bi2 = -bi2;
                }
            }
            catch (Exception)
            {
            }

            var result = new BigInteger();

            // multiply the absolute values
            try
            {
                for (var i = 0; i < bi1.DataLength; i++)
                {
                    if (bi1._data[i] == 0)
                        continue;

                    ulong mcarry = 0;
                    for (int j = 0, k = i; j < bi2.DataLength; j++, k++)
                    {
                        // k = i + j
                        var val = (bi1._data[i] * (ulong)bi2._data[j]) +
                                    result._data[k] + mcarry;

                        result._data[k] = (uint)(val & 0xFFFFFFFF);
                        mcarry = (val >> 32);
                    }

                    if (mcarry != 0)
                        result._data[i + bi2.DataLength] = (uint)mcarry;
                }
            }
            catch (Exception)
            {
                throw (new ArithmeticException("Multiplication overflow."));
            }

            result.DataLength = bi1.DataLength + bi2.DataLength;
            if (result.DataLength > MAX_LENGTH)
                result.DataLength = MAX_LENGTH;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            // overflow check (result is -ve)
            if ((result._data[lastPos] & 0x80000000) != 0)
            {
                if (bi1Neg != bi2Neg && result._data[lastPos] == 0x80000000) // different sign
                {
                    // handle the special case where multiplication produces
                    // a max negative number in 2's complement.

                    if (result.DataLength == 1)
                        return result;
                    else
                    {
                        var isMaxNeg = true;
                        for (var i = 0; i < result.DataLength - 1 && isMaxNeg; i++)
                        {
                            if (result._data[i] != 0)
                                isMaxNeg = false;
                        }

                        if (isMaxNeg)
                            return result;
                    }
                }

                throw (new ArithmeticException("Multiplication overflow."));
            }

            // if input has different signs, then result is -ve
            if (bi1Neg != bi2Neg)
                return -result;

            return result;
        }

        public static BigInteger operator *(BigInteger bi1, long bi2)
        {
            return bi1 * (BigInteger)bi2;
        }

        public static BigInteger operator *(BigInteger bi1, ulong bi2)
        {
            return bi1 * (BigInteger)bi2;
        }

        public static BigInteger operator *(BigInteger bi1, int bi2)
        {
            return bi1 * (BigInteger)bi2;
        }

        public static BigInteger operator *(BigInteger bi1, uint bi2)
        {
            return bi1 * (BigInteger)bi2;
        }

        //***********************************************************************
        // Private function that supports the division of two numbers with
        // a divisor that has more than 1 digit.
        //
        // Algorithm taken from [1]
        //***********************************************************************

        private static void MultiByteDivide(BigInteger bi1, BigInteger bi2,
                                            BigInteger outQuotient, BigInteger outRemainder)
        {
            var result = new uint[MAX_LENGTH];

            var remainderLen = bi1.DataLength + 1;
            var remainder = new uint[remainderLen];

            var mask = 0x80000000;
            var val = bi2._data[bi2.DataLength - 1];
            int shift = 0, resultPos = 0;

            while (mask != 0 && (val & mask) == 0)
            {
                shift++;
                mask >>= 1;
            }

            //Console.WriteLine("shift = {0}", shift);
            //Console.WriteLine("Before bi1 Len = {0}, bi2 Len = {1}", bi1.dataLength, bi2.dataLength);

            for (var i = 0; i < bi1.DataLength; i++)
                remainder[i] = bi1._data[i];
            ShiftLeft(remainder, shift);
            bi2 = bi2 << shift;

            /*
            Console.WriteLine("bi1 Len = {0}, bi2 Len = {1}", bi1.dataLength, bi2.dataLength);
            Console.WriteLine("dividend = " + bi1 + "\ndivisor = " + bi2);
            for(int q = remainderLen - 1; q >= 0; q--)
                    Console.Write("{0:x2}", remainder[q]);
            Console.WriteLine();
            */

            var j = remainderLen - bi2.DataLength;
            var pos = remainderLen - 1;

            ulong firstDivisorByte = bi2._data[bi2.DataLength - 1];
            ulong secondDivisorByte = bi2._data[bi2.DataLength - 2];

            var divisorLen = bi2.DataLength + 1;
            var dividendPart = new uint[divisorLen];

            while (j > 0)
            {
                var dividend = ((ulong)remainder[pos] << 32) + remainder[pos - 1];
                //Console.WriteLine("dividend = {0}", dividend);

                var q_hat = dividend / firstDivisorByte;
                var r_hat = dividend % firstDivisorByte;

                //Console.WriteLine("q_hat = {0:X}, r_hat = {1:X}", q_hat, r_hat);

                var done = false;
                while (!done)
                {
                    done = true;

                    if (q_hat == 0x100000000 ||
                        (q_hat * secondDivisorByte) > ((r_hat << 32) + remainder[pos - 2]))
                    {
                        q_hat--;
                        r_hat += firstDivisorByte;

                        if (r_hat < 0x100000000)
                            done = false;
                    }
                }

                for (var h = 0; h < divisorLen; h++)
                    dividendPart[h] = remainder[pos - h];

                var kk = new BigInteger(dividendPart);
                var ss = bi2 * (long)q_hat;

                //Console.WriteLine("ss before = " + ss);
                while (ss > kk)
                {
                    q_hat--;
                    ss -= bi2;
                    //Console.WriteLine(ss);
                }

                var yy = kk - ss;

                //Console.WriteLine("ss = " + ss);
                //Console.WriteLine("kk = " + kk);
                //Console.WriteLine("yy = " + yy);

                for (var h = 0; h < divisorLen; h++)
                    remainder[pos - h] = yy._data[bi2.DataLength - h];

                /*
                Console.WriteLine("dividend = ");
                for(int q = remainderLen - 1; q >= 0; q--)
                        Console.Write("{0:x2}", remainder[q]);
                Console.WriteLine("\n************ q_hat = {0:X}\n", q_hat);
                */

                result[resultPos++] = (uint)q_hat;

                pos--;
                j--;
            }

            outQuotient.DataLength = resultPos;
            var y = 0;
            for (var x = outQuotient.DataLength - 1; x >= 0; x--, y++)
                outQuotient._data[y] = result[x];
            for (; y < MAX_LENGTH; y++)
                outQuotient._data[y] = 0;

            while (outQuotient.DataLength > 1 && outQuotient._data[outQuotient.DataLength - 1] == 0)
                outQuotient.DataLength--;

            if (outQuotient.DataLength == 0)
                outQuotient.DataLength = 1;

            outRemainder.DataLength = ShiftRight(remainder, shift);

            for (y = 0; y < outRemainder.DataLength; y++)
                outRemainder._data[y] = remainder[y];
            for (; y < MAX_LENGTH; y++)
                outRemainder._data[y] = 0;
        }

        //***********************************************************************
        // Private function that supports the division of two numbers with
        // a divisor that has only 1 digit.
        //***********************************************************************

        private static void SingleByteDivide(BigInteger bi1, BigInteger bi2,
                                             BigInteger outQuotient, BigInteger outRemainder)
        {
            var result = new uint[MAX_LENGTH];
            var resultPos = 0;

            // copy dividend to reminder
            for (var i = 0; i < MAX_LENGTH; i++)
                outRemainder._data[i] = bi1._data[i];
            outRemainder.DataLength = bi1.DataLength;

            while (outRemainder.DataLength > 1 && outRemainder._data[outRemainder.DataLength - 1] == 0)
                outRemainder.DataLength--;

            ulong divisor = bi2._data[0];
            var pos = outRemainder.DataLength - 1;
            ulong dividend = outRemainder._data[pos];

            //Console.WriteLine("divisor = " + divisor + " dividend = " + dividend);
            //Console.WriteLine("divisor = " + bi2 + "\ndividend = " + bi1);

            if (dividend >= divisor)
            {
                var quotient = dividend / divisor;
                result[resultPos++] = (uint)quotient;

                outRemainder._data[pos] = (uint)(dividend % divisor);
            }

            pos--;

            while (pos >= 0)
            {
                //Console.WriteLine(pos);

                dividend = ((ulong)outRemainder._data[pos + 1] << 32) + outRemainder._data[pos];
                var quotient = dividend / divisor;
                result[resultPos++] = (uint)quotient;

                outRemainder._data[pos + 1] = 0;
                outRemainder._data[pos--] = (uint)(dividend % divisor);
                //Console.WriteLine(">>>> " + bi1);
            }

            outQuotient.DataLength = resultPos;
            var j = 0;
            for (var i = outQuotient.DataLength - 1; i >= 0; i--, j++)
                outQuotient._data[j] = result[i];
            for (; j < MAX_LENGTH; j++)
                outQuotient._data[j] = 0;

            while (outQuotient.DataLength > 1 && outQuotient._data[outQuotient.DataLength - 1] == 0)
                outQuotient.DataLength--;

            if (outQuotient.DataLength == 0)
                outQuotient.DataLength = 1;

            while (outRemainder.DataLength > 1 && outRemainder._data[outRemainder.DataLength - 1] == 0)
                outRemainder.DataLength--;
        }

        //***********************************************************************
        // Overloading of division operator
        //***********************************************************************

        public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
        {
            var quotient = new BigInteger();
            var remainder = new BigInteger();

            var lastPos = MAX_LENGTH - 1;
            bool divisorNeg = false, dividendNeg = false;

            if ((bi1._data[lastPos] & 0x80000000) != 0) // bi1 negative
            {
                bi1 = -bi1;
                dividendNeg = true;
            }

            if ((bi2._data[lastPos] & 0x80000000) != 0) // bi2 negative
            {
                bi2 = -bi2;
                divisorNeg = true;
            }

            if (bi1 < bi2)
            {
                return quotient;
            }
            else
            {
                if (bi2.DataLength == 1)
                    SingleByteDivide(bi1, bi2, quotient, remainder);
                else
                    MultiByteDivide(bi1, bi2, quotient, remainder);

                if (dividendNeg != divisorNeg)
                    return -quotient;

                return quotient;
            }
        }

        public static BigInteger operator /(BigInteger bi1, long bi2)
        {
            return bi1 / (BigInteger)bi2;
        }

        public static BigInteger operator /(BigInteger bi1, ulong bi2)
        {
            return bi1 / (BigInteger)bi2;
        }

        public static BigInteger operator /(BigInteger bi1, int bi2)
        {
            return bi1 / (BigInteger)bi2;
        }

        public static BigInteger operator /(BigInteger bi1, uint bi2)
        {
            return bi1 / (BigInteger)bi2;
        }

        //***********************************************************************
        // Overloading of modulus operator
        //***********************************************************************

        public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
        {
            var quotient = new BigInteger();
            var remainder = new BigInteger(bi1);

            var lastPos = MAX_LENGTH - 1;
            var dividendNeg = false;

            if ((bi1._data[lastPos] & 0x80000000) != 0) // bi1 negative
            {
                bi1 = -bi1;
                dividendNeg = true;
            }

            if ((bi2._data[lastPos] & 0x80000000) != 0) // bi2 negative
                bi2 = -bi2;

            if (bi1 < bi2)
            {
                return remainder;
            }
            else
            {
                if (bi2.DataLength == 1)
                    SingleByteDivide(bi1, bi2, quotient, remainder);
                else
                    MultiByteDivide(bi1, bi2, quotient, remainder);

                if (dividendNeg)
                    return -remainder;

                return remainder;
            }
        }

        public static BigInteger operator %(BigInteger bi1, long bi2)
        {
            return bi1 % (BigInteger)bi2;
        }

        public static BigInteger operator %(BigInteger bi1, ulong bi2)
        {
            return bi1 % (BigInteger)bi2;
        }

        public static BigInteger operator %(BigInteger bi1, int bi2)
        {
            return bi1 % (BigInteger)bi2;
        }

        public static BigInteger operator %(BigInteger bi1, uint bi2)
        {
            return bi1 % (BigInteger)bi2;
        }

        public static BigInteger operator %(long bi1, BigInteger bi2)
        {
            return (BigInteger)bi1 % bi2;
        }

        public static BigInteger operator %(ulong bi1, BigInteger bi2)
        {
            return (BigInteger)bi1 % bi2;
        }

        public static BigInteger operator %(int bi1, BigInteger bi2)
        {
            return (BigInteger)bi1 % bi2;
        }

        public static BigInteger operator %(uint bi1, BigInteger bi2)
        {
            return (BigInteger)bi1 % bi2;
        }

        #endregion Overloading of multiplication, division and modulus

        #region Overloading of << >> operators

        public static BigInteger operator <<(BigInteger bi1, int shiftVal)
        {
            var result = new BigInteger(bi1);
            result.DataLength = ShiftLeft(result._data, shiftVal);

            return result;
        }

        // least significant bits at lower part of buffer

        private static int ShiftLeft(uint[] buffer, int shiftVal)
        {
            var shiftAmount = 32;
            var bufLen = buffer.Length;

            while (bufLen > 1 && buffer[bufLen - 1] == 0)
                bufLen--;

            for (var count = shiftVal; count > 0;)
            {
                if (count < shiftAmount)
                    shiftAmount = count;

                //Console.WriteLine("shiftAmount = {0}", shiftAmount);

                ulong carry = 0;
                for (var i = 0; i < bufLen; i++)
                {
                    var val = ((ulong)buffer[i]) << shiftAmount;
                    val |= carry;

                    buffer[i] = (uint)(val & 0xFFFFFFFF);
                    carry = val >> 32;
                }

                if (carry != 0)
                {
                    if (bufLen + 1 <= buffer.Length)
                    {
                        buffer[bufLen] = (uint)carry;
                        bufLen++;
                    }
                }

                count -= shiftAmount;
            }

            return bufLen;
        }

        //***********************************************************************
        // Overloading of unary >> operators
        //***********************************************************************

        public static BigInteger operator >>(BigInteger bi1, int shiftVal)
        {
            var result = new BigInteger(bi1);
            result.DataLength = ShiftRight(result._data, shiftVal);

            if ((bi1._data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
            {
                for (var i = MAX_LENGTH - 1; i >= result.DataLength; i--)
                    result._data[i] = 0xFFFFFFFF;

                var mask = 0x80000000;
                for (var i = 0; i < 32; i++)
                {
                    if ((result._data[result.DataLength - 1] & mask) != 0)
                        break;

                    result._data[result.DataLength - 1] |= mask;
                    mask >>= 1;
                }

                result.DataLength = MAX_LENGTH;
            }

            return result;
        }

        private static int ShiftRight(uint[] buffer, int shiftVal)
        {
            var shiftAmount = 32;
            var invShift = 0;
            var bufLen = buffer.Length;

            while (bufLen > 1 && buffer[bufLen - 1] == 0)
                bufLen--;

            //Console.WriteLine("bufLen = " + bufLen + " buffer.Length = " + buffer.Length);

            for (var count = shiftVal; count > 0;)
            {
                if (count < shiftAmount)
                {
                    shiftAmount = count;
                    invShift = 32 - shiftAmount;
                }

                //Console.WriteLine("shiftAmount = {0}", shiftAmount);

                ulong carry = 0;
                for (var i = bufLen - 1; i >= 0; i--)
                {
                    var val = ((ulong)buffer[i]) >> shiftAmount;
                    val |= carry;

                    carry = ((ulong)buffer[i]) << invShift;
                    buffer[i] = (uint)(val);
                }

                count -= shiftAmount;
            }

            while (bufLen > 1 && buffer[bufLen - 1] == 0)
                bufLen--;

            return bufLen;
        }

        #endregion Overloading of << >> operators

        #region Overloading of the bitwise operators (NOT, AND, OR, XOR)

        /// <summary>
        /// NOT operator (1's complement)
        /// </summary>
        /// <param name="bi1">the number</param>
        /// <returns></returns>
        public static BigInteger operator ~(BigInteger bi1)
        {
            var result = new BigInteger(bi1);

            for (var i = 0; i < MAX_LENGTH; i++)
                result._data[i] = ~(bi1._data[i]);

            result.DataLength = MAX_LENGTH;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            return result;
        }

        //***********************************************************************
        // Overloading of bitwise AND operator
        //***********************************************************************

        public static BigInteger operator &(BigInteger bi1, BigInteger bi2)
        {
            var result = new BigInteger();

            var len = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;

            for (var i = 0; i < len; i++)
            {
                var sum = bi1._data[i] & bi2._data[i];
                result._data[i] = sum;
            }

            result.DataLength = MAX_LENGTH;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            return result;
        }

        //***********************************************************************
        // Overloading of bitwise OR operator
        //***********************************************************************

        public static BigInteger operator |(BigInteger bi1, BigInteger bi2)
        {
            var result = new BigInteger();

            var len = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;

            for (var i = 0; i < len; i++)
            {
                var sum = bi1._data[i] | bi2._data[i];
                result._data[i] = sum;
            }

            result.DataLength = MAX_LENGTH;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            return result;
        }

        //***********************************************************************
        // Overloading of bitwise XOR operator
        //***********************************************************************

        public static BigInteger operator ^(BigInteger bi1, BigInteger bi2)
        {
            var result = new BigInteger();

            var len = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;

            for (var i = 0; i < len; i++)
            {
                var sum = bi1._data[i] ^ bi2._data[i];
                result._data[i] = sum;
            }

            result.DataLength = MAX_LENGTH;

            while (result.DataLength > 1 && result._data[result.DataLength - 1] == 0)
                result.DataLength--;

            return result;
        }

        #endregion Overloading of the bitwise operators (NOT, AND, OR, XOR)

        #region Overloading of comparison operators

        public static bool operator ==(BigInteger? bi1, BigInteger? bi2)
        {
            if (bi1 == null && bi2 == null)
                return true;
            if (bi1 as object == null && bi2 as object == null)
                return true;
            else if (bi1 as object == null || bi2 as object == null)
                return false;

            return bi1.Equals(bi2);
        }

        public static bool operator ==(BigInteger bi1, uint bi2)
        {
            return bi1 == (BigInteger)bi2;
        }

        public static bool operator ==(BigInteger bi1, int bi2)
        {
            return bi1 == (BigInteger)bi2;
        }

        public static bool operator ==(BigInteger bi1, long bi2)
        {
            return bi1 == (BigInteger)bi2;
        }

        public static bool operator ==(BigInteger bi1, ulong bi2)
        {
            return bi1 == (BigInteger)bi2;
        }

        public static bool operator !=(BigInteger bi1, BigInteger bi2)
        {
            if (bi1 is null && bi2 is null)
                return false;
            else if (bi1 is null || bi2 is null)
                return true;
            else
                return !(bi1.Equals(bi2));
        }

        public static bool operator !=(BigInteger bi1, uint bi2)
        {
            return bi1 != (BigInteger)bi2;
        }

        public static bool operator !=(BigInteger bi1, int bi2)
        {
            return bi1 != (BigInteger)bi2;
        }

        public static bool operator !=(BigInteger bi1, long bi2)
        {
            return bi1 != (BigInteger)bi2;
        }

        public static bool operator !=(BigInteger bi1, ulong bi2)
        {
            return bi1 != (BigInteger)bi2;
        }

        public override bool Equals(object? o)
        {
            var bi = o as BigInteger;

            if (bi is null)
                return false;

            if (DataLength != bi.DataLength)
                return false;

            for (var i = 0; i < DataLength; i++)
            {
                if (_data[i] != bi._data[i])
                    return false;
            }

            return true;
        }

        //***********************************************************************
        // Overloading of inequality operator
        //***********************************************************************

        public static bool operator >(BigInteger bi1, BigInteger bi2)
        {
            var pos = MAX_LENGTH - 1;

            // bi1 is negative, bi2 is positive
            if ((bi1._data[pos] & 0x80000000) != 0 && (bi2._data[pos] & 0x80000000) == 0)
                return false;

            // bi1 is positive, bi2 is negative
            else if ((bi1._data[pos] & 0x80000000) == 0 && (bi2._data[pos] & 0x80000000) != 0)
                return true;

            // same sign
            var len = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;
            for (pos = len - 1; pos >= 0 && bi1._data[pos] == bi2._data[pos]; pos--)
                ;

            if (pos >= 0)
            {
                if (bi1._data[pos] > bi2._data[pos])
                    return true;
                return false;
            }

            return false;
        }

        public static bool operator >(BigInteger bi1, long bi2)
        {
            return bi1 > (BigInteger)bi2;
        }

        public static bool operator >(BigInteger bi1, ulong bi2)
        {
            return bi1 > (BigInteger)bi2;
        }

        public static bool operator >(BigInteger bi1, int bi2)
        {
            return bi1 > (BigInteger)bi2;
        }

        public static bool operator >(BigInteger bi1, uint bi2)
        {
            return bi1 > (BigInteger)bi2;
        }

        public static bool operator <(BigInteger bi1, BigInteger bi2)
        {
            var pos = MAX_LENGTH - 1;

            // bi1 is negative, bi2 is positive
            if ((bi1._data[pos] & 0x80000000) != 0 && (bi2._data[pos] & 0x80000000) == 0)
                return true;

            // bi1 is positive, bi2 is negative
            else if ((bi1._data[pos] & 0x80000000) == 0 && (bi2._data[pos] & 0x80000000) != 0)
                return false;

            // same sign
            var len = (bi1.DataLength > bi2.DataLength) ? bi1.DataLength : bi2.DataLength;
            for (pos = len - 1; pos >= 0 && bi1._data[pos] == bi2._data[pos]; pos--)
                ;

            if (pos >= 0)
            {
                if (bi1._data[pos] < bi2._data[pos])
                    return true;
                return false;
            }

            return false;
        }

        public static bool operator <(BigInteger bi1, long bi2)
        {
            return bi1 < (BigInteger)bi2;
        }

        public static bool operator <(BigInteger bi1, ulong bi2)
        {
            return bi1 < (BigInteger)bi2;
        }

        public static bool operator <(BigInteger bi1, int bi2)
        {
            return bi1 < (BigInteger)bi2;
        }

        public static bool operator <(BigInteger bi1, uint bi2)
        {
            return bi1 < (BigInteger)bi2;
        }

        public static bool operator >=(BigInteger bi1, BigInteger bi2)
        {
            return (bi1 == bi2 || bi1 > bi2);
        }

        public static bool operator >=(BigInteger bi1, long bi2)
        {
            return bi1 >= (BigInteger)bi2;
        }

        public static bool operator >=(BigInteger bi1, ulong bi2)
        {
            return bi1 >= (BigInteger)bi2;
        }

        public static bool operator >=(BigInteger bi1, int bi2)
        {
            return bi1 >= (BigInteger)bi2;
        }

        public static bool operator >=(BigInteger bi1, uint bi2)
        {
            return bi1 >= (BigInteger)bi2;
        }

        public static bool operator <=(BigInteger bi1, BigInteger bi2)
        {
            return (bi1 == bi2 || bi1 < bi2);
        }

        public static bool operator <=(BigInteger bi1, long bi2)
        {
            return bi1 <= (BigInteger)bi2;
        }

        public static bool operator <=(BigInteger bi1, ulong bi2)
        {
            return bi1 <= (BigInteger)bi2;
        }

        public static bool operator <=(BigInteger bi1, int bi2)
        {
            return bi1 <= (BigInteger)bi2;
        }

        public static bool operator <=(BigInteger bi1, uint bi2)
        {
            return bi1 <= (BigInteger)bi2;
        }

        #endregion Overloading of comparison operators

        #region Max, min, abs

        //***********************************************************************
        // Returns max(this, bi)
        //***********************************************************************

        public BigInteger Max(BigInteger bi)
        {
            if (this > bi)
                return (new BigInteger(this));
            else
                return (new BigInteger(bi));
        }

        //***********************************************************************
        // Returns min(this, bi)
        //***********************************************************************

        public BigInteger Min(BigInteger bi)
        {
            if (this < bi)
                return (new BigInteger(this));
            else
                return (new BigInteger(bi));
        }

        //***********************************************************************
        // Returns the absolute value
        //***********************************************************************

        public BigInteger Abs()
        {
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0)
                return (-this);
            else
                return (new BigInteger(this));
        }

        #endregion Max, min, abs

        #region ToString, GetHashCode

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        //***********************************************************************
        // Returns a string representing the BigInteger in base 10.
        //***********************************************************************

        public override string ToString()
        {
            return "0x" + ToString(16);
        }

        //***********************************************************************
        // Returns a string representing the BigInteger in sign-and-magnitude
        // format in the specified radix.
        //
        // Example
        // -------
        // If the value of BigInteger is -255 in base 10, then
        // ToString(16) returns "-FF"
        //
        //***********************************************************************

        public string ToString(int radix)
        {
            if (radix < 2 || radix > 36)
                throw (new ArgumentException("Radix must be >= 2 and <= 36"));

            var charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = "";

            var a = this;

            var negative = false;
            if ((a._data[MAX_LENGTH - 1] & 0x80000000) != 0)
            {
                negative = true;
                try
                {
                    a = -a;
                }
                catch (Exception)
                {
                }
            }

            var quotient = new BigInteger();
            var remainder = new BigInteger();
            var biRadix = new BigInteger(radix);

            if (a.DataLength == 1 && a._data[0] == 0)
                result = "0";
            else
            {
                while (a.DataLength > 1 || (a.DataLength == 1 && a._data[0] != 0))
                {
                    SingleByteDivide(a, biRadix, quotient, remainder);

                    if (remainder._data[0] < 10)
                        result = remainder._data[0] + result;
                    else
                        result = charSet[(int)remainder._data[0] - 10] + result;

                    a = quotient;
                }

                if (negative)
                    result = "-" + result;
            }

            return result;
        }

        //***********************************************************************
        // Returns a hex string showing the contains of the BigInteger
        //
        // Examples
        // -------
        // 1) If the value of BigInteger is 255 in base 10, then
        //    ToHexString() returns "FF"
        //
        // 2) If the value of BigInteger is -255 in base 10, then
        //    ToHexString() returns ".....FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF01",
        //    which is the 2's complement representation of -255.
        //
        //***********************************************************************

        public string ToHexString()
        {
            var result = _data[DataLength - 1].ToString("X");

            for (var i = DataLength - 2; i >= 0; i--)
            {
                result += _data[i].ToString("X8");
            }

            return result;
        }

        #endregion ToString, GetHashCode

        //***********************************************************************
        // Modulo Exponentiation
        //***********************************************************************

        public BigInteger ModPow(BigInteger exp, BigInteger n)
        {
            if ((exp._data[MAX_LENGTH - 1] & 0x80000000) != 0)
                throw (new ArithmeticException("Positive exponents only."));

            var resultNum = (BigInteger)1;
            BigInteger tempNum;
            var thisNegative = false;

            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative this
            {
                tempNum = -this % n;
                thisNegative = true;
            }
            else
                tempNum = this % n; // ensures (tempNum * tempNum) < b^(2k)

            if ((n._data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative n
                n = -n;

            // calculate constant = b^(2k) / m
            var constant = new BigInteger();

            var i = n.DataLength << 1;
            constant._data[i] = 0x00000001;
            constant.DataLength = i + 1;

            constant = constant / n;
            var totalBits = exp.BitCount();
            var count = 0;

            // perform squaring and multiply exponentiation
            for (var pos = 0; pos < exp.DataLength; pos++)
            {
                uint mask = 0x01;
                //Console.WriteLine("pos = " + pos);

                for (var index = 0; index < 32; index++)
                {
                    if ((exp._data[pos] & mask) != 0)
                        resultNum = BarrettReduction(resultNum * tempNum, n, constant);

                    mask <<= 1;

                    tempNum = BarrettReduction(tempNum * tempNum, n, constant);

                    if (tempNum.DataLength == 1 && tempNum._data[0] == 1)
                    {
                        if (thisNegative && (exp._data[0] & 0x1) != 0) //odd exp
                            return -resultNum;
                        return resultNum;
                    }

                    count++;
                    if (count == totalBits)
                        break;
                }
            }

            if (thisNegative && (exp._data[0] & 0x1) != 0) //odd exp
                return -resultNum;

            return resultNum;
        }

        //***********************************************************************
        // Fast calculation of modular reduction using Barrett's reduction.
        // Requires x < b^(2k), where b is the base.  In this case, base is
        // 2^32 (uint).
        //
        // Reference [4]
        //***********************************************************************

        private static BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant)
        {
            int k = n.DataLength,
                kPlusOne = k + 1,
                kMinusOne = k - 1;

            var q1 = new BigInteger();

            // q1 = x / b^(k-1)
            for (int i = kMinusOne, j = 0; i < x.DataLength; i++, j++)
                q1._data[j] = x._data[i];
            q1.DataLength = x.DataLength - kMinusOne;
            if (q1.DataLength <= 0)
                q1.DataLength = 1;

            var q2 = q1 * constant;
            var q3 = new BigInteger();

            // q3 = q2 / b^(k+1)
            for (int i = kPlusOne, j = 0; i < q2.DataLength; i++, j++)
                q3._data[j] = q2._data[i];
            q3.DataLength = q2.DataLength - kPlusOne;
            if (q3.DataLength <= 0)
                q3.DataLength = 1;

            // r1 = x mod b^(k+1)
            // i.e. keep the lowest (k+1) words
            var r1 = new BigInteger();
            var lengthToCopy = (x.DataLength > kPlusOne) ? kPlusOne : x.DataLength;
            for (var i = 0; i < lengthToCopy; i++)
                r1._data[i] = x._data[i];
            r1.DataLength = lengthToCopy;

            // r2 = (q3 * n) mod b^(k+1)
            // partial multiplication of q3 and n

            var r2 = new BigInteger();
            for (var i = 0; i < q3.DataLength; i++)
            {
                if (q3._data[i] == 0)
                    continue;

                ulong mcarry = 0;
                var t = i;
                for (var j = 0; j < n.DataLength && t < kPlusOne; j++, t++)
                {
                    // t = i + j
                    var val = (q3._data[i] * (ulong)n._data[j]) +
                                r2._data[t] + mcarry;

                    r2._data[t] = (uint)(val & 0xFFFFFFFF);
                    mcarry = (val >> 32);
                }

                if (t < kPlusOne)
                    r2._data[t] = (uint)mcarry;
            }

            r2.DataLength = kPlusOne;
            while (r2.DataLength > 1 && r2._data[r2.DataLength - 1] == 0)
                r2.DataLength--;

            r1 -= r2;
            if ((r1._data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
            {
                var val = new BigInteger();
                val._data[kPlusOne] = 0x00000001;
                val.DataLength = kPlusOne + 1;
                r1 += val;
            }

            while (r1 >= n)
                r1 -= n;

            return r1;
        }

        //***********************************************************************
        // Returns gcd(this, bi)
        //***********************************************************************

        public BigInteger GCD(BigInteger bi)
        {
            BigInteger x;
            BigInteger y;

            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                x = -this;
            else
                x = this;

            if ((bi._data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                y = -bi;
            else
                y = bi;

            var g = y;

            while (x.DataLength > 1 || (x.DataLength == 1 && x._data[0] != 0))
            {
                g = x;
                x = y % x;
                y = g;
            }

            return g;
        }

        //***********************************************************************
        // Populates "this" with the specified amount of random bits
        //***********************************************************************

        public void GenerateRandomBits(int bits, Random rand)
        {
            var dwords = bits >> 5;
            var remBits = bits & 0x1F;

            if (remBits != 0)
                dwords++;

            if (dwords > MAX_LENGTH)
                throw (new ArithmeticException("Number of required bits > maxLength."));

            for (var i = 0; i < dwords; i++)
                _data[i] = (uint)(rand.NextDouble() * 0x100000000);

            for (var i = dwords; i < MAX_LENGTH; i++)
                _data[i] = 0;

            if (remBits != 0)
            {
                var mask = (uint)(0x01 << (remBits - 1));
                _data[dwords - 1] |= mask;

                mask = 0xFFFFFFFF >> (32 - remBits);
                _data[dwords - 1] &= mask;
            }
            else
                _data[dwords - 1] |= 0x80000000;

            DataLength = dwords;

            if (DataLength == 0)
                DataLength = 1;
        }

        //***********************************************************************
        // Returns the position of the most significant bit in the BigInteger.
        //
        // Eg.  The result is 0, if the value of BigInteger is 0...0000 0000
        //      The result is 1, if the value of BigInteger is 0...0000 0001
        //      The result is 2, if the value of BigInteger is 0...0000 0010
        //      The result is 2, if the value of BigInteger is 0...0000 0011
        //
        //***********************************************************************

        public int BitCount()
        {
            while (DataLength > 1 && _data[DataLength - 1] == 0)
                DataLength--;

            var value = _data[DataLength - 1];
            var mask = 0x80000000;
            var bits = 32;

            while (bits > 0 && (value & mask) == 0)
            {
                bits--;
                mask >>= 1;
            }

            bits += ((DataLength - 1) << 5);

            return bits;
        }

        #region Primality testing

        //***********************************************************************
        // Probabilistic prime test based on Fermat's little theorem
        //
        // for any a < p (p does not divide a) if
        //      a^(p-1) mod p != 1 then p is not prime.
        //
        // Otherwise, p is probably prime (pseudoprime to the chosen base).
        //
        // Returns
        // -------
        // True if "this" is a pseudoprime to randomly chosen
        // bases.  The number of chosen bases is given by the "confidence"
        // parameter.
        //
        // False if "this" is definitely NOT prime.
        //
        // Note - this method is fast but fails for Carmichael numbers except
        // when the randomly chosen base is a factor of the number.
        //
        //***********************************************************************

        public bool FermatLittleTest(int confidence)
        {
            BigInteger thisVal;
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                thisVal = -this;
            else
                thisVal = this;

            if (thisVal.DataLength == 1)
            {
                // test small numbers
                if (thisVal._data[0] == 0 || thisVal._data[0] == 1)
                    return false;
                else if (thisVal._data[0] == 2 || thisVal._data[0] == 3)
                    return true;
            }

            if ((thisVal._data[0] & 0x1) == 0) // even numbers
                return false;

            var bits = thisVal.BitCount();
            var a = new BigInteger();
            var p_sub1 = thisVal - (new BigInteger(1));
            var rand = new Random();

            for (var round = 0; round < confidence; round++)
            {
                var done = false;

                while (!done) // generate a < n
                {
                    var testBits = 0;

                    // make sure "a" has at least 2 bits
                    while (testBits < 2)
                        testBits = (int)(rand.NextDouble() * bits);

                    a.GenerateRandomBits(testBits, rand);

                    var byteLen = a.DataLength;

                    // make sure "a" is not 0
                    if (byteLen > 1 || (byteLen == 1 && a._data[0] != 1))
                        done = true;
                }

                // check whether a factor exists (fix for version 1.03)
                var gcdTest = a.GCD(thisVal);
                if (gcdTest.DataLength == 1 && gcdTest._data[0] != 1)
                    return false;

                // calculate a^(p-1) mod p
                var expResult = a.ModPow(p_sub1, thisVal);

                var resultLen = expResult.DataLength;

                // is NOT prime is a^(p-1) mod p != 1

                if (resultLen > 1 || (resultLen == 1 && expResult._data[0] != 1))
                {
                    //Console.WriteLine("a = " + a.ToString());
                    return false;
                }
            }

            return true;
        }

        //***********************************************************************
        // Probabilistic prime test based on Rabin-Miller's
        //
        // for any p > 0 with p - 1 = 2^s * t
        //
        // p is probably prime (strong pseudoprime) if for any a < p,
        // 1) a^t mod p = 1 or
        // 2) a^((2^j)*t) mod p = p-1 for some 0 <= j <= s-1
        //
        // Otherwise, p is composite.
        //
        // Returns
        // -------
        // True if "this" is a strong pseudoprime to randomly chosen
        // bases.  The number of chosen bases is given by the "confidence"
        // parameter.
        //
        // False if "this" is definitely NOT prime.
        //
        //***********************************************************************

        public bool RabinMillerTest(int confidence)
        {
            BigInteger thisVal;
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                thisVal = -this;
            else
                thisVal = this;

            if (thisVal.DataLength == 1)
            {
                // test small numbers
                if (thisVal._data[0] == 0 || thisVal._data[0] == 1)
                    return false;
                else if (thisVal._data[0] == 2 || thisVal._data[0] == 3)
                    return true;
            }

            if ((thisVal._data[0] & 0x1) == 0) // even numbers
                return false;

            // calculate values of s and t
            var p_sub1 = thisVal - (new BigInteger(1));
            var s = 0;

            for (var index = 0; index < p_sub1.DataLength; index++)
            {
                uint mask = 0x01;

                for (var i = 0; i < 32; i++)
                {
                    if ((p_sub1._data[index] & mask) != 0)
                    {
                        index = p_sub1.DataLength; // to break the outer loop
                        break;
                    }

                    mask <<= 1;
                    s++;
                }
            }

            var t = p_sub1 >> s;

            var bits = thisVal.BitCount();
            var a = new BigInteger();
            var rand = new Random();

            for (var round = 0; round < confidence; round++)
            {
                var done = false;

                while (!done) // generate a < n
                {
                    var testBits = 0;

                    // make sure "a" has at least 2 bits
                    while (testBits < 2)
                        testBits = (int)(rand.NextDouble() * bits);

                    a.GenerateRandomBits(testBits, rand);

                    var byteLen = a.DataLength;

                    // make sure "a" is not 0
                    if (byteLen > 1 || (byteLen == 1 && a._data[0] != 1))
                        done = true;
                }

                // check whether a factor exists (fix for version 1.03)
                var gcdTest = a.GCD(thisVal);
                if (gcdTest.DataLength == 1 && gcdTest._data[0] != 1)
                    return false;

                var b = a.ModPow(t, thisVal);

                /*
                Console.WriteLine("a = " + a.ToString(10));
                Console.WriteLine("b = " + b.ToString(10));
                Console.WriteLine("t = " + t.ToString(10));
                Console.WriteLine("s = " + s);
                */

                var result = false;

                if (b.DataLength == 1 && b._data[0] == 1) // a^t mod p = 1
                    result = true;

                for (var j = 0; result == false && j < s; j++)
                {
                    if (b == p_sub1) // a^((2^j)*t) mod p = p-1 for some 0 <= j <= s-1
                    {
                        result = true;
                        break;
                    }

                    b = (b * b) % thisVal;
                }

                if (result == false)
                    return false;
            }

            return true;
        }

        //***********************************************************************
        // Probabilistic prime test based on Solovay-Strassen (Euler Criterion)
        //
        // p is probably prime if for any a < p (a is not multiple of p),
        // a^((p-1)/2) mod p = J(a, p)
        //
        // where J is the Jacobi symbol.
        //
        // Otherwise, p is composite.
        //
        // Returns
        // -------
        // True if "this" is a Euler pseudoprime to randomly chosen
        // bases.  The number of chosen bases is given by the "confidence"
        // parameter.
        //
        // False if "this" is definitely NOT prime.
        //
        //***********************************************************************

        public bool SolovayStrassenTest(int confidence)
        {
            BigInteger thisVal;
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                thisVal = -this;
            else
                thisVal = this;

            if (thisVal.DataLength == 1)
            {
                // test small numbers
                if (thisVal._data[0] == 0 || thisVal._data[0] == 1)
                    return false;
                else if (thisVal._data[0] == 2 || thisVal._data[0] == 3)
                    return true;
            }

            if ((thisVal._data[0] & 0x1) == 0) // even numbers
                return false;

            var bits = thisVal.BitCount();
            var a = new BigInteger();
            var p_sub1 = thisVal - 1;
            var p_sub1_shift = p_sub1 >> 1;

            var rand = new Random();

            for (var round = 0; round < confidence; round++)
            {
                var done = false;

                while (!done) // generate a < n
                {
                    var testBits = 0;

                    // make sure "a" has at least 2 bits
                    while (testBits < 2)
                        testBits = (int)(rand.NextDouble() * bits);

                    a.GenerateRandomBits(testBits, rand);

                    var byteLen = a.DataLength;

                    // make sure "a" is not 0
                    if (byteLen > 1 || (byteLen == 1 && a._data[0] != 1))
                        done = true;
                }

                // check whether a factor exists (fix for version 1.03)
                var gcdTest = a.GCD(thisVal);
                if (gcdTest.DataLength == 1 && gcdTest._data[0] != 1)
                    return false;

                // calculate a^((p-1)/2) mod p

                var expResult = a.ModPow(p_sub1_shift, thisVal);
                if (expResult == p_sub1)
                    expResult = (BigInteger)(-1);

                // calculate Jacobi symbol
                var jacob = (BigInteger)Jacobi(a, thisVal);

                //Console.WriteLine("a = " + a.ToString(10) + " b = " + thisVal.ToString(10));
                //Console.WriteLine("expResult = " + expResult.ToString(10) + " Jacob = " + jacob.ToString(10));

                // if they are different then it is not prime
                if (expResult != jacob)
                    return false;
            }

            return true;
        }

        //***********************************************************************
        // Implementation of the Lucas Strong Pseudo Prime test.
        //
        // Let n be an odd number with gcd(n,D) = 1, and n - J(D, n) = 2^s * d
        // with d odd and s >= 0.
        //
        // If Ud mod n = 0 or V2^r*d mod n = 0 for some 0 <= r < s, then n
        // is a strong Lucas pseudoprime with parameters (P, Q).  We select
        // P and Q based on Selfridge.
        //
        // Returns True if number is a strong Lucus pseudo prime.
        // Otherwise, returns False indicating that number is composite.
        //***********************************************************************

        public bool LucasStrongTest()
        {
            BigInteger thisVal;
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                thisVal = -this;
            else
                thisVal = this;

            if (thisVal.DataLength == 1)
            {
                // test small numbers
                if (thisVal._data[0] == 0 || thisVal._data[0] == 1)
                    return false;
                else if (thisVal._data[0] == 2 || thisVal._data[0] == 3)
                    return true;
            }

            if ((thisVal._data[0] & 0x1) == 0) // even numbers
                return false;

            return LucasStrongTestHelper(thisVal);
        }

        private static bool LucasStrongTestHelper(BigInteger thisVal)
        {
            // Do the test (selects D based on Selfridge)
            // Let D be the first element of the sequence
            // 5, -7, 9, -11, 13, ... for which J(D,n) = -1
            // Let P = 1, Q = (1-D) / 4

            long D = 5, sign = -1, dCount = 0;
            var done = false;

            while (!done)
            {
                var Jresult = Jacobi((BigInteger)D, thisVal);

                if (Jresult == -1)
                    done = true; // J(D, this) = 1
                else
                {
                    if (Jresult == 0 && thisVal > Math.Abs(D)) // divisor found
                        return false;

                    if (dCount == 20)
                    {
                        // check for square
                        var root = thisVal.Sqrt();
                        if (root * root == thisVal)
                            return false;
                    }

                    //Console.WriteLine(D);
                    D = (Math.Abs(D) + 2) * sign;
                    sign = -sign;
                }

                dCount++;
            }

            var Q = (1 - D) >> 2;

            /*
            Console.WriteLine("D = " + D);
            Console.WriteLine("Q = " + Q);
            Console.WriteLine("(n,D) = " + thisVal.gcd(D));
            Console.WriteLine("(n,Q) = " + thisVal.gcd(Q));
            Console.WriteLine("J(D|n) = " + BigInteger.Jacobi(D, thisVal));
            */

            var p_add1 = thisVal + 1;
            var s = 0;

            for (var index = 0; index < p_add1.DataLength; index++)
            {
                uint mask = 0x01;

                for (var i = 0; i < 32; i++)
                {
                    if ((p_add1._data[index] & mask) != 0)
                    {
                        index = p_add1.DataLength; // to break the outer loop
                        break;
                    }

                    mask <<= 1;
                    s++;
                }
            }

            var t = p_add1 >> s;

            // calculate constant = b^(2k) / m
            // for Barrett Reduction
            var constant = new BigInteger();

            var nLen = thisVal.DataLength << 1;
            constant._data[nLen] = 0x00000001;
            constant.DataLength = nLen + 1;

            constant = constant / thisVal;

            var lucas =
                LucasSequenceHelper((BigInteger)1, (BigInteger)Q, t, thisVal,
                                    constant, 0);
            var isPrime = false;

            if ((lucas[0].DataLength == 1 && lucas[0]._data[0] == 0) ||
                (lucas[1].DataLength == 1 && lucas[1]._data[0] == 0))
            {
                // u(t) = 0 or V(t) = 0
                isPrime = true;
            }

            for (var i = 1; i < s; i++)
            {
                if (!isPrime)
                {
                    // doubling of index
                    lucas[1] = BarrettReduction(lucas[1] * lucas[1], thisVal, constant);
                    lucas[1] = (lucas[1] - (lucas[2] << 1)) % thisVal;

                    //lucas[1] = ((lucas[1] * lucas[1]) - (lucas[2] << 1)) % thisVal;

                    if ((lucas[1].DataLength == 1 && lucas[1]._data[0] == 0))
                        isPrime = true;
                }

                lucas[2] = BarrettReduction(lucas[2] * lucas[2], thisVal, constant); //Q^k
            }

            if (isPrime) // additional checks for composite numbers
            {
                // If n is prime and gcd(n, Q) == 1, then
                // Q^((n+1)/2) = Q * Q^((n-1)/2) is congruent to (Q * J(Q, n)) mod n

                var g = thisVal.GCD((BigInteger)Q);
                if (g.DataLength == 1 && g._data[0] == 1) // gcd(this, Q) == 1
                {
                    if ((lucas[2]._data[MAX_LENGTH - 1] & 0x80000000) != 0)
                        lucas[2] += thisVal;

                    var temp = (Q * Jacobi((BigInteger)Q, thisVal)) % thisVal;
                    if ((temp._data[MAX_LENGTH - 1] & 0x80000000) != 0)
                        temp += thisVal;

                    if (lucas[2] != temp)
                        isPrime = false;
                }
            }

            return isPrime;
        }

        //***********************************************************************
        // Determines whether a number is probably prime, using the Rabin-Miller's
        // test.  Before applying the test, the number is tested for divisibility
        // by primes < 2000
        //
        // Returns true if number is probably prime.
        //***********************************************************************

        public bool IsProbablePrime(int confidence)
        {
            BigInteger thisVal;
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                thisVal = -this;
            else
                thisVal = this;

            // test for divisibility by primes < 2000
            for (var p = 0; p < PrimesBelow2000.Length; p++)
            {
                var divisor = (BigInteger)PrimesBelow2000[p];

                if (divisor >= thisVal)
                    break;

                var resultNum = thisVal % divisor;
                if (resultNum.IntValue() == 0)
                {
                    /*
    Console.WriteLine("Not prime!  Divisible by {0}\n",
                                      primesBelow2000[p]);
                    */
                    return false;
                }
            }

            if (thisVal.RabinMillerTest(confidence))
                return true;
            else
            {
                //Console.WriteLine("Not prime!  Failed primality test\n");
                return false;
            }
        }

        //***********************************************************************
        // Determines whether this BigInteger is probably prime using a
        // combination of base 2 strong pseudoprime test and Lucas strong
        // pseudoprime test.
        //
        // The sequence of the primality test is as follows,
        //
        // 1) Trial divisions are carried out using prime numbers below 2000.
        //    if any of the primes divides this BigInteger, then it is not prime.
        //
        // 2) Perform base 2 strong pseudoprime test.  If this BigInteger is a
        //    base 2 strong pseudoprime, proceed on to the next step.
        //
        // 3) Perform strong Lucas pseudoprime test.
        //
        // Returns True if this BigInteger is both a base 2 strong pseudoprime
        // and a strong Lucas pseudoprime.
        //
        // For a detailed discussion of this primality test, see [6].
        //
        //***********************************************************************

        public bool IsProbablePrime()
        {
            BigInteger thisVal;
            if ((_data[MAX_LENGTH - 1] & 0x80000000) != 0) // negative
                thisVal = -this;
            else
                thisVal = this;

            if (thisVal.DataLength == 1)
            {
                // test small numbers
                if (thisVal._data[0] == 0 || thisVal._data[0] == 1)
                    return false;
                else if (thisVal._data[0] == 2 || thisVal._data[0] == 3)
                    return true;
            }

            if ((thisVal._data[0] & 0x1) == 0) // even numbers
                return false;

            // test for divisibility by primes < 2000
            for (var p = 0; p < PrimesBelow2000.Length; p++)
            {
                var divisor = (BigInteger)PrimesBelow2000[p];

                if (divisor >= thisVal)
                    break;

                var resultNum = thisVal % divisor;
                if (resultNum.IntValue() == 0)
                {
                    //Console.WriteLine("Not prime!  Divisible by {0}\n",
                    //                  primesBelow2000[p]);

                    return false;
                }
            }

            // Perform BASE 2 Rabin-Miller Test

            // calculate values of s and t
            var p_sub1 = thisVal - (new BigInteger(1));
            var s = 0;

            for (var index = 0; index < p_sub1.DataLength; index++)
            {
                uint mask = 0x01;

                for (var i = 0; i < 32; i++)
                {
                    if ((p_sub1._data[index] & mask) != 0)
                    {
                        index = p_sub1.DataLength; // to break the outer loop
                        break;
                    }

                    mask <<= 1;
                    s++;
                }
            }

            var t = p_sub1 >> s;

            var a = (BigInteger)2;

            // b = a^t mod p
            var b = a.ModPow(t, thisVal);
            var result = false;

            if (b.DataLength == 1 && b._data[0] == 1) // a^t mod p = 1
                result = true;

            for (var j = 0; result == false && j < s; j++)
            {
                if (b == p_sub1) // a^((2^j)*t) mod p = p-1 for some 0 <= j <= s-1
                {
                    result = true;
                    break;
                }

                b = (b * b) % thisVal;
            }

            // if number is strong pseudoprime to base 2, then do a strong lucas test
            if (result)
                result = LucasStrongTestHelper(thisVal);

            return result;
        }

        #endregion Primality testing

        #region Primality generation

        //***********************************************************************
        // Generates a positive BigInteger that is probably prime.
        //***********************************************************************

        public static BigInteger GenPseudoPrime(int bits, int confidence, Random rand)
        {
            var result = new BigInteger();
            var done = false;

            while (!done)
            {
                result.GenerateRandomBits(bits, rand);
                result._data[0] |= 0x01; // make it odd

                // prime test
                done = result.IsProbablePrime(confidence);
            }

            return result;
        }

        //***********************************************************************
        // Generates a random number with the specified number of bits such
        // that gcd(number, this) = 1
        //***********************************************************************

        public BigInteger GenCoPrime(int bits, Random rand)
        {
            var done = false;
            var result = new BigInteger();

            while (!done)
            {
                result.GenerateRandomBits(bits, rand);
                //Console.WriteLine(result.ToString(16));

                // gcd test
                var g = result.GCD(this);
                if (g.DataLength == 1 && g._data[0] == 1)
                    done = true;
            }

            return result;
        }

        #endregion Primality generation

        public byte LeastSignificantByte()
        {
            return ByteValue();
        }

        //***********************************************************************
        // Returns the lowest byte of the BigInteger as a byte.
        //***********************************************************************

        public byte ByteValue()
        {
            return (byte)_data[0];
        }

        //***********************************************************************
        // Returns the lowest 4 bytes of the BigInteger as an int.
        //***********************************************************************

        public int IntValue()
        {
            return (int)_data[0];
        }

        //***********************************************************************
        // Returns the lowest 8 bytes of the BigInteger as a long.
        //***********************************************************************

        public long LongValue()
        {
            long val;

            val = _data[0];
            try
            {
                // exception if maxLength = 1
                val |= (long)_data[1] << 32;
            }
            catch (Exception)
            {
                if ((_data[0] & 0x80000000) != 0) // negative
                    val = (int)_data[0];
            }

            return val;
        }

        //***********************************************************************
        // Computes the Jacobi Symbol for a and b.
        // Algorithm adapted from [3] and [4] with some optimizations
        //***********************************************************************

        public static int Jacobi(BigInteger a, BigInteger b)
        {
            // Jacobi defined only for odd integers
            if ((b._data[0] & 0x1) == 0)
                throw (new ArgumentException("Jacobi defined only for odd integers."));

            if (a >= b)
                a %= b;
            if (a.DataLength == 1 && a._data[0] == 0)
                return 0; // a == 0
            if (a.DataLength == 1 && a._data[0] == 1)
                return 1; // a == 1

            if (a < 0)
            {
                if ((((b - 1)._data[0]) & 0x2) == 0) //if( (((b-1) >> 1).data[0] & 0x1) == 0)
                    return Jacobi(-a, b);
                else
                    return -Jacobi(-a, b);
            }

            var e = 0;
            for (var index = 0; index < a.DataLength; index++)
            {
                uint mask = 0x01;

                for (var i = 0; i < 32; i++)
                {
                    if ((a._data[index] & mask) != 0)
                    {
                        index = a.DataLength; // to break the outer loop
                        break;
                    }

                    mask <<= 1;
                    e++;
                }
            }

            var a1 = a >> e;

            var s = 1;
            if ((e & 0x1) != 0 && ((b._data[0] & 0x7) == 3 || (b._data[0] & 0x7) == 5))
                s = -1;

            if ((b._data[0] & 0x3) == 3 && (a1._data[0] & 0x3) == 3)
                s = -s;

            if (a1.DataLength == 1 && a1._data[0] == 1)
                return s;
            else
                return (s * Jacobi(b % a1, a1));
        }

        //***********************************************************************
        // Returns the modulo inverse of   Throws ArithmeticException if
        // the inverse does not exist.  (i.e. gcd(this, modulus) != 1)
        //***********************************************************************

        public BigInteger ModInverse(BigInteger modulus)
        {
            BigInteger[] p = { (BigInteger)0, (BigInteger)1 };
            var q = new BigInteger[2]; // quotients
            BigInteger[] r = { (BigInteger)0, (BigInteger)0 }; // remainders

            var step = 0;

            var a = modulus;
            var b = this;

            while (b.DataLength > 1 || (b.DataLength == 1 && b._data[0] != 0))
            {
                var quotient = new BigInteger();
                var remainder = new BigInteger();

                if (step > 1)
                {
                    var pval = (p[0] - (p[1] * q[0])) % modulus;
                    p[0] = p[1];
                    p[1] = pval;
                }

                if (b.DataLength == 1)
                    SingleByteDivide(a, b, quotient, remainder);
                else
                    MultiByteDivide(a, b, quotient, remainder);

                /*
                Console.WriteLine(quotient.dataLength);
                Console.WriteLine("{0} = {1}({2}) + {3}  p = {4}", a.ToString(10),
                                  b.ToString(10), quotient.ToString(10), remainder.ToString(10),
                                  p[1].ToString(10));
                */

                q[0] = q[1];
                r[0] = r[1];
                q[1] = quotient;
                r[1] = remainder;

                a = b;
                b = remainder;

                step++;
            }

            if (r[0].DataLength > 1 || (r[0].DataLength == 1 && r[0]._data[0] != 1))
                throw (new ArithmeticException("No inverse!"));

            var result = ((p[0] - (p[1] * q[0])) % modulus);

            if ((result._data[MAX_LENGTH - 1] & 0x80000000) != 0)
                result += modulus; // get the least positive modulus

            return result;
        }

        public byte[] GetBytes()
        {
            var numBits = BitCount();
            var numBytes = numBits >> 3;
            if ((numBits & 0x7) != 0)
                numBytes++;

            return GetBytes(numBytes);
        }

        public byte[] GetBytesBE()
        {
            var numBits = BitCount();
            var numBytes = numBits >> 3;
            if ((numBits & 0x7) != 0)
                numBytes++;

            return GetBytesBE(numBytes);
        }

        //***********************************************************************
        // Returns the value of the BigInteger as a byte array.  The lowest
        // index contains the MSB.
        //***********************************************************************

        public byte[] GetBytes(int numBytes)
        {
            var result = new byte[numBytes];

            var numBits = BitCount();
            var realNumBytes = numBits >> 3;
            if ((numBits & 0x7) != 0)
                realNumBytes++;

            for (var i = 0; i < realNumBytes; i++)
            {
                for (var b = 0; b < 4; b++)
                {
                    if (i * 4 + b >= realNumBytes)
                        return result;
                    result[i * 4 + b] = (byte)(_data[i] >> (b * 8) & 0xff);
                }
            }

            return result;
        }

        protected static void Reverse<T>(T[] buffer, int length)
        {
            for (var i = 0; i < length / 2; i++)
            {
                var temp = buffer[i];
                buffer[i] = buffer[length - i - 1];
                buffer[length - i - 1] = temp;
            }
        }

        protected static void Reverse<T>(T[] buffer)
        {
            Reverse(buffer, buffer.Length);
        }

        public byte[] GetBytesBE(int numBytes)
        {
            // I am lazy.
            var result = GetBytes(numBytes);
            Reverse(result);
            return result;
        }

        //***********************************************************************
        // Sets the value of the specified bit to 1
        // The Least Significant Bit position is 0.
        //***********************************************************************

        public void SetBit(uint bitNum)
        {
            var bytePos = bitNum >> 5; // divide by 32
            var bitPos = (byte)(bitNum & 0x1F); // get the lowest 5 bits

            var mask = (uint)1 << bitPos;
            _data[bytePos] |= mask;

            if (bytePos >= DataLength)
                DataLength = (int)bytePos + 1;
        }

        //***********************************************************************
        // Sets the value of the specified bit to 0
        // The Least Significant Bit position is 0.
        //***********************************************************************

        public void UnsetBit(uint bitNum)
        {
            var bytePos = bitNum >> 5;

            if (bytePos < DataLength)
            {
                var bitPos = (byte)(bitNum & 0x1F);

                var mask = (uint)1 << bitPos;
                var mask2 = 0xFFFFFFFF ^ mask;

                _data[bytePos] &= mask2;

                if (DataLength > 1 && _data[DataLength - 1] == 0)
                    DataLength--;
            }
        }

        //***********************************************************************
        // Returns a value that is equivalent to the integer square root
        // of the BigInteger.
        //
        // The integer square root of "this" is defined as the largest integer n
        // such that (n * n) <= this
        //
        //***********************************************************************

        public BigInteger Sqrt()
        {
            var numBits = (uint)BitCount();

            if ((numBits & 0x1) != 0) // odd number of bits
                numBits = (numBits >> 1) + 1;
            else
                numBits = (numBits >> 1);

            var bytePos = numBits >> 5;
            var bitPos = (byte)(numBits & 0x1F);

            uint mask;

            var result = new BigInteger();
            if (bitPos == 0)
                mask = 0x80000000;
            else
            {
                mask = (uint)1 << bitPos;
                bytePos++;
            }

            result.DataLength = (int)bytePos;

            for (var i = (int)bytePos - 1; i >= 0; i--)
            {
                while (mask != 0)
                {
                    // guess
                    result._data[i] ^= mask;

                    // undo the guess if its square is larger than this
                    if ((result * result) > this)
                        result._data[i] ^= mask;

                    mask >>= 1;
                }

                mask = 0x80000000;
            }

            return result;
        }

        //***********************************************************************
        // Returns the k_th number in the Lucas Sequence reduced modulo n.
        //
        // Uses index doubling to speed up the process.  For example, to calculate V(k),
        // we maintain two numbers in the sequence V(n) and V(n+1).
        //
        // To obtain V(2n), we use the identity
        //      V(2n) = (V(n) * V(n)) - (2 * Q^n)
        // To obtain V(2n+1), we first write it as
        //      V(2n+1) = V((n+1) + n)
        // and use the identity
        //      V(m+n) = V(m) * V(n) - Q * V(m-n)
        // Hence,
        //      V((n+1) + n) = V(n+1) * V(n) - Q^n * V((n+1) - n)
        //                   = V(n+1) * V(n) - Q^n * V(1)
        //                   = V(n+1) * V(n) - Q^n * P
        //
        // We use k in its binary expansion and perform index doubling for each
        // bit position.  For each bit position that is set, we perform an
        // index doubling followed by an index addition.  This means that for V(n),
        // we need to update it to V(2n+1).  For V(n+1), we need to update it to
        // V((2n+1)+1) = V(2*(n+1))
        //
        // This function returns
        // [0] = U(k)
        // [1] = V(k)
        // [2] = Q^n
        //
        // Where U(0) = 0 % n, U(1) = 1 % n
        //       V(0) = 2 % n, V(1) = P % n
        //***********************************************************************

        public static BigInteger[] LucasSequence(BigInteger P, BigInteger Q,
                                                 BigInteger k, BigInteger n)
        {
            if (k.DataLength == 1 && k._data[0] == 0)
            {
                var result = new BigInteger[3];

                result[0] = (BigInteger)0;
                result[1] = 2 % n;
                result[2] = 1 % n;
                return result;
            }

            // calculate constant = b^(2k) / m
            // for Barrett Reduction
            var constant = new BigInteger();

            var nLen = n.DataLength << 1;
            constant._data[nLen] = 0x00000001;
            constant.DataLength = nLen + 1;

            constant = constant / n;

            // calculate values of s and t
            var s = 0;

            for (var index = 0; index < k.DataLength; index++)
            {
                uint mask = 0x01;

                for (var i = 0; i < 32; i++)
                {
                    if ((k._data[index] & mask) != 0)
                    {
                        index = k.DataLength; // to break the outer loop
                        break;
                    }

                    mask <<= 1;
                    s++;
                }
            }

            var t = k >> s;

            //Console.WriteLine("s = " + s + " t = " + t);
            return LucasSequenceHelper(P, Q, t, n, constant, s);
        }

        //***********************************************************************
        // Performs the calculation of the kth term in the Lucas Sequence.
        // For details of the algorithm, see reference [9].
        //
        // k must be odd.  i.e LSB == 1
        //***********************************************************************

        private static BigInteger[] LucasSequenceHelper(BigInteger P, BigInteger Q,
                                                        BigInteger k, BigInteger n,
                                                        BigInteger constant, int s)
        {
            var result = new BigInteger[3];

            if ((k._data[0] & 0x00000001) == 0)
                throw (new ArgumentException("Argument k must be odd."));

            var numbits = k.BitCount();
            var mask = (uint)0x1 << ((numbits & 0x1F) - 1);

            // v = v0, v1 = v1, u1 = u1, Q_k = Q^0

            BigInteger v = 2 % n,
                       Q_k = 1 % n,
                       v1 = P % n,
                       u1 = Q_k;
            var flag = true;

            for (var i = k.DataLength - 1; i >= 0; i--) // iterate on the binary expansion of k
            {
                //Console.WriteLine("round");
                while (mask != 0)
                {
                    if (i == 0 && mask == 0x00000001) // last bit
                        break;

                    if ((k._data[i] & mask) != 0) // bit is set
                    {
                        // index doubling with addition

                        u1 = (u1 * v1) % n;

                        v = ((v * v1) - (P * Q_k)) % n;
                        v1 = BarrettReduction(v1 * v1, n, constant);
                        v1 = (v1 - ((Q_k * Q) << 1)) % n;

                        if (flag)
                            flag = false;
                        else
                            Q_k = BarrettReduction(Q_k * Q_k, n, constant);

                        Q_k = (Q_k * Q) % n;
                    }
                    else
                    {
                        // index doubling
                        u1 = ((u1 * v) - Q_k) % n;

                        v1 = ((v * v1) - (P * Q_k)) % n;
                        v = BarrettReduction(v * v, n, constant);
                        v = (v - (Q_k << 1)) % n;

                        if (flag)
                        {
                            Q_k = Q % n;
                            flag = false;
                        }
                        else
                            Q_k = BarrettReduction(Q_k * Q_k, n, constant);
                    }

                    mask >>= 1;
                }

                mask = 0x80000000;
            }

            // at this point u1 = u(n+1) and v = v(n)
            // since the last bit always 1, we need to transform u1 to u(2n+1) and v to v(2n+1)

            u1 = ((u1 * v) - Q_k) % n;
            v = ((v * v1) - (P * Q_k)) % n;
            if (flag)
                flag = false;
            else
                Q_k = BarrettReduction(Q_k * Q_k, n, constant);

            Q_k = (Q_k * Q) % n;

            for (var i = 0; i < s; i++)
            {
                // index doubling
                u1 = (u1 * v) % n;
                v = ((v * v) - (Q_k << 1)) % n;

                if (flag)
                {
                    Q_k = Q % n;
                    flag = false;
                }
                else
                    Q_k = BarrettReduction(Q_k * Q_k, n, constant);
            }

            result[0] = u1;
            result[1] = v;
            result[2] = Q_k;

            return result;
        }
    }

    [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
    public partial class BigInteger : object, ISerializable
    {
        private SerializationInfo _info;

        public BigInteger(SerializationInfo info, StreamingContext context)
        {
            this._info = info;
        }

        public SerializationInfo SerializationInfo
        {
            get { return _info; }
            set { _info = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if ((SerializationInfo == null))
            {
                return;
            }

            var enumerator = SerializationInfo.GetEnumerator();
            for (
                ;
                enumerator.MoveNext();
                )
            {
                var entry = enumerator.Current;
                info.AddValue(entry.Name, entry.Value);
            }
        }
    }
}