using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LSCode.Validations.Test.Unit")]
namespace LSCode.Validations.Test.Tools.Mocks.BooleanValidations.Extensions
{
    internal static class IsNotEmptyValidationExtensionMockData
    {
        public static readonly object[] IsNotEmpty_Guid_ShouldReturnTrue_Data =
        {
            new object[] { Guid.Parse("c1aadc5a-e9bb-44b5-a22e-cd2a59ff7e67") },
            new object[] { Guid.Parse("e4b10727-7a8c-48cf-b6f7-5c6b6c59c534") },
            new object[] { Guid.Parse("837c4bff-3ade-419b-b815-13568d40ddab") },
        };

        public static readonly object[] IsNotEmpty_Guid_ShouldReturnFalse_Data =
        {
            new object[] { Guid.Empty },
        };

        public static readonly object[] IsNotEmpty_IEnumerable_ShouldReturnTrue_Data =
        {
            new object[] { new List<int>() { 1, 2, } },
            new object[] { new List<int>() { 1, 2, 3, 4 } },
        };

        public static readonly object[] IsNotEmpty_IEnumerable_ShouldReturnFalse_Data =
        {
            new object[] { new List<int>() },
        };
    }
}