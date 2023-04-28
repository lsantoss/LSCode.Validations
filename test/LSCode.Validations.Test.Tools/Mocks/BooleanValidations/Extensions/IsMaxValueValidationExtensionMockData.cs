using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class IsMaxValueValidationExtensionMockData
    {
        public static readonly object[] IsMaxValue_decimal_ShouldReturnTrue_Data =
        {
            new object[] { decimal.MaxValue },
        };

        public static readonly object[] IsMaxValue_char_ShouldReturnTrue_Data =
        {
            new object[] { char.MaxValue },
        };

        public static readonly object[] IsMaxValue_Datetime_ShouldReturnTrue_Data =
        {
            new object[] { DateTime.MaxValue },
        };

        public static readonly object[] IsMaxValue_Datetime_ShouldReturnFalse_Data =
        {
            new object[] { DateTime.MinValue },
            new object[] { new DateTime(2023, 3, 3) },
            new object[] { new DateTime(2024, 4, 4) },
        };

        public static readonly object[] IsMaxValue_TimeSpan_ShouldReturnTrue_Data =
        {
            new object[] { TimeSpan.MaxValue },
        };

        public static readonly object[] IsMaxValue_TimeSpan_ShouldReturnFalse_Data =
        {
            new object[] { TimeSpan.MinValue },
            new object[] { new TimeSpan(1) },
            new object[] { new TimeSpan(10) },
            new object[] { new TimeSpan(100) },
        };
    }
}