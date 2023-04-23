using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class HasNotLengthEqualToExtensionMockData
    {
        public static readonly object[] HasNotLengthEqualTo_IEnumerable_sbyte_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), (sbyte)1 },
            new object[] { new List<int>() { 1 }, (sbyte)2 },
            new object[] { new List<int>() { 1, 2 }, (sbyte)3 },
            new object[] { new List<int>() { 1, 2, 3 }, (sbyte)4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_sbyte_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), (sbyte)0 },
            new object[] { new List<int>() { 1 }, (sbyte)1 },
            new object[] { new List<int>() { 1, 2 }, (sbyte)2 },
            new object[] { new List<int>() { 1, 2, 3 }, (sbyte)3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_byte_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), (byte)1 },
            new object[] { new List<int>() { 1 }, (byte)2 },
            new object[] { new List<int>() { 1, 2 }, (byte)3 },
            new object[] { new List<int>() { 1, 2, 3 }, (byte)4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_byte_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), (byte)0 },
            new object[] { new List<int>() { 1 }, (byte)1 },
            new object[] { new List<int>() { 1, 2 }, (byte)2 },
            new object[] { new List<int>() { 1, 2, 3 }, (byte)3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_short_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), (short)1 },
            new object[] { new List<int>() { 1 }, (short)2 },
            new object[] { new List<int>() { 1, 2 }, (short)3 },
            new object[] { new List<int>() { 1, 2, 3 }, (short)4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_short_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), (short)0 },
            new object[] { new List<int>() { 1 }, (short)1 },
            new object[] { new List<int>() { 1, 2 }, (short)2 },
            new object[] { new List<int>() { 1, 2, 3 }, (short)3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_ushort_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), (ushort)1 },
            new object[] { new List<int>() { 1 }, (ushort)2 },
            new object[] { new List<int>() { 1, 2 }, (ushort)3 },
            new object[] { new List<int>() { 1, 2, 3 }, (ushort)4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_ushort_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), (ushort)0 },
            new object[] { new List<int>() { 1 }, (ushort)1 },
            new object[] { new List<int>() { 1, 2 }, (ushort)2 },
            new object[] { new List<int>() { 1, 2, 3 }, (ushort)3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_int_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), 1 },
            new object[] { new List<int>() { 1 }, 2 },
            new object[] { new List<int>() { 1, 2 }, 3 },
            new object[] { new List<int>() { 1, 2, 3 }, 4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_int_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), 0 },
            new object[] { new List<int>() { 1 }, 1 },
            new object[] { new List<int>() { 1, 2 }, 2 },
            new object[] { new List<int>() { 1, 2, 3 }, 3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_uint_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), (uint)1 },
            new object[] { new List<int>() { 1 }, (uint)2 },
            new object[] { new List<int>() { 1, 2 }, (uint)3 },
            new object[] { new List<int>() { 1, 2, 3 }, (uint)4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_uint_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), (uint)0 },
            new object[] { new List<int>() { 1 }, (uint)1 },
            new object[] { new List<int>() { 1, 2 }, (uint)2 },
            new object[] { new List<int>() { 1, 2, 3 }, (uint)3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_long_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), 1 },
            new object[] { new List<int>() { 1 }, 2 },
            new object[] { new List<int>() { 1, 2 }, 3 },
            new object[] { new List<int>() { 1, 2, 3 }, 4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_long_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), 0 },
            new object[] { new List<int>() { 1 }, 1 },
            new object[] { new List<int>() { 1, 2 }, 2 },
            new object[] { new List<int>() { 1, 2, 3 }, 3 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_ulong_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>(), (ulong)1 },
            new object[] { new List<int>() { 1 }, (ulong)2 },
            new object[] { new List<int>() { 1, 2 }, (ulong)3 },
            new object[] { new List<int>() { 1, 2, 3 }, (ulong)4 },
        };

        public static readonly object[] HasNotLengthEqualTo_IEnumerable_ulong_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>(), (ulong)0 },
            new object[] { new List<int>() { 1 }, (ulong)1 },
            new object[] { new List<int>() { 1, 2 }, (ulong)2 },
            new object[] { new List<int>() { 1, 2, 3 }, (ulong)3 },
        };
    }
}