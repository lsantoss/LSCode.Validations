using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class IsNotMinValueExtensionMockData
    {
        public static readonly object[] IsNotMinValue_decimal_ShouldReturnFalse_Data =
        {
            new object[] { decimal.MinValue },
        };

        public static readonly object[] IsNotMinValue_DateTime_ShouldReturnTrue_Data =
        {
            new object[] { DateTime.MaxValue },
            new object[] { new DateTime(2023, 3, 3) },
            new object[] { new DateTime(2024, 4, 4) },
        };

        public static readonly object[] IsNotMinValue_DateTime_ShouldReturnFalse_Data =
        {
            new object[] { DateTime.MinValue },
        };

        public static readonly object[] IsNotMinValue_TimeSpan_ShouldReturnTrue_Data =
        {
            new object[] { TimeSpan.MaxValue },
            new object[] { new TimeSpan(1) },
            new object[] { new TimeSpan(10) },
            new object[] { new TimeSpan(100) },
        };

        public static readonly object[] IsNotMinValue_TimeSpan_ShouldReturnFalse_Data =
        {
            new object[] { TimeSpan.MinValue },
        };
    }
}