using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class IsLowerOrEqualsThanExtentionMockData
    {
        public static readonly object[] IsLowerOrEqualsThan_Datetime_Datetime_ShouldReturnTrue_Data =
        {
            new object[] { new DateTime(2021, 01, 11), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2021, 01, 12) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2021, 02, 11) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 01, 11) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2021, 02, 12) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 01, 12) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 02, 11) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 02, 12) },
        };

        public static readonly object[] IsLowerOrEqualsThan_Datetime_Datetime_ShouldReturnFalse_Data =
        {
            new object[] { new DateTime(2021, 01, 12), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2021, 02, 11), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2022, 01, 11), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2021, 02, 12), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2022, 01, 12), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2022, 02, 11), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2022, 02, 12), new DateTime(2021, 01, 11) },
        };

        public static readonly object[] IsLowerOrEqualsThan_Timespan_Timespan_ShouldReturnTrue_Data =
        {
            new object[] { new TimeSpan(1), new TimeSpan(1) },
            new object[] { new TimeSpan(1), new TimeSpan(2) },
            new object[] { new TimeSpan(10), new TimeSpan(20) },
            new object[] { new TimeSpan(100), new TimeSpan(200) },
        };

        public static readonly object[] IsLowerOrEqualsThan_Timespan_Timespan_ShouldReturnFalse_Data =
        {
            new object[] { new TimeSpan(2), new TimeSpan(1) },
            new object[] { new TimeSpan(20), new TimeSpan(10) },
            new object[] { new TimeSpan(200), new TimeSpan(100) },
        };
    }
}