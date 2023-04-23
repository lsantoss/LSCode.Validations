using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class IsNotEqualToExtensionMockData
    {
        public static readonly object[] IsNotEqualTo_string_Guid_ShouldReturnTrue_Data =
        {
            new object[] { "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67", Guid.Parse("2f3d1a60-b870-4375-8874-2b8fe359518e") },
            new object[] { "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67", Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534") },
            new object[] { "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67", Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab") },
        };

        public static readonly object[] IsNotEqualTo_string_Guid_ShouldReturnFalse_Data =
        {
            new object[] { "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67", Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67") },
            new object[] { "e4b10727-7a8c-48cf-b6f7-5c6b6c59c534", Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534") },
            new object[] { "837c4bff-3ade-419b-b815-13568d40ddab", Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab") },
        };

        public static readonly object[] IsNotEqualTo_Guid_Guid_ShouldReturnTrue_Data =
        {
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), Guid.Parse("2f3d1a60-b870-4375-8874-2b8fe359518e") },
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534") },
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab") },
        };

        public static readonly object[] IsNotEqualTo_Guid_Guid_ShouldReturnFalse_Data =
        {
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67") },
            new object[] { Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534"), Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534") },
            new object[] { Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab"), Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab") },
        };

        public static readonly object[] IsNotEqualTo_Guid_string_ShouldReturnTrue_Data =
        {
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), "2f3d1a60-b870-4375-8874-2b8fe359518e" },
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), "e4b10727-7a8c-48cf-b6f7-5c6b6c59c534" },
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), "837c4bff-3ade-419b-b815-13568d40ddab" },
        };

        public static readonly object[] IsNotEqualTo_Guid_string_ShouldReturnFalse_Data =
        {
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67"), "c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67" },
            new object[] { Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534"), "e4b10727-7a8c-48cf-b6f7-5c6b6c59c534" },
            new object[] { Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab"), "837c4bff-3ade-419b-b815-13568d40ddab" },
        };

        public static readonly object[] IsNotEqualTo_Datetime_Datetime_ShouldReturnTrue_Data =
        {
            new object[] { new DateTime(2021, 01, 11), new DateTime(2023, 02, 12) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 03, 12) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 02, 13) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2023, 03, 11) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2023, 02, 13) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 03, 13) },
            new object[] { new DateTime(2021, 01, 11), new DateTime(2022, 02, 12) },
        };

        public static readonly object[] IsNotEqualTo_Datetime_Datetime_ShouldReturnFalse_Data =
        {
            new object[] { new DateTime(2021, 01, 11), new DateTime(2021, 01, 11) },
            new object[] { new DateTime(2022, 02, 12), new DateTime(2022, 02, 12) },
            new object[] { new DateTime(2023, 03, 13), new DateTime(2023, 03, 13) },
            new object[] { new DateTime(2024, 04, 14), new DateTime(2024, 04, 14) },
        };

        public static readonly object[] IsNotEqualTo_TimeSpan_TimeSpan_ShouldReturnTrue_Data =
        {
            new object[] { new TimeSpan(1), new TimeSpan(2) },
            new object[] { new TimeSpan(10), new TimeSpan(20) },
            new object[] { new TimeSpan(100), new TimeSpan(200) },
        };

        public static readonly object[] IsNotEqualTo_TimeSpan_TimeSpan_ShouldReturnFalse_Data =
        {
            new object[] { new TimeSpan(1), new TimeSpan(1) },
            new object[] { new TimeSpan(10), new TimeSpan(10) },
            new object[] { new TimeSpan(100), new TimeSpan(100) },
        };

        public static readonly object[] IsNotEqualTo_IEnumerable_IEnumerable_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>() { 1, 2, 3, 4 }, new List<int>() { 1, 2, 3, 4, 5 } },
        };

        public static readonly object[] IsNotEqualTo_IEnumerable_IEnumerable_ShouldReturnFalse_Data =
        {
            new object[] { null, null },
            new object[] { new List<int>() { 1, 2, 3, 4 }, new List<int>() { 1, 2, 3, 4 } },
        };
    }
}