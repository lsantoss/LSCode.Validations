using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class IsNotMaxValueValidationExtensionMockData
    {
        public static readonly object[] IsNotMaxValue_decimal_ShouldReturnFalse_Data =
        {
            new object[] { decimal.MaxValue },
        };

        public static readonly object[] IsNotMaxValue_char_ShouldReturnFalse_Data =
        {
            new object[] { char.MaxValue },
        };

        public static readonly object[] IsNotMaxValue_DateTime_ShouldReturnTrue_Data =
        {
            new object[] { DateTime.MinValue },
            new object[] { new DateTime(2023, 3, 3) },
            new object[] { new DateTime(2024, 4, 4) },
        };

        public static readonly object[] IsNotMaxValue_DateTime_ShouldReturnFalse_Data =
        {
            new object[] { DateTime.MaxValue },
        };

        public static readonly object[] IsNotMaxValue_TimeSpan_ShouldReturnTrue_Data =
        {
            new object[] { TimeSpan.MinValue },
            new object[] { new TimeSpan(1) },
            new object[] { new TimeSpan(10) },
            new object[] { new TimeSpan(100) },
        };

        public static readonly object[] IsNotMaxValue_TimeSpan_ShouldReturnFalse_Data =
        {
            new object[] { TimeSpan.MaxValue },
        };
    }
}