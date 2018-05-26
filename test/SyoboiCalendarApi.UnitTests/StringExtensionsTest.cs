using System;
using System.Collections.Generic;
using System.Text;
using SyoboiCalendarApi;
using Xunit;

namespace SyoboiCalendarApi.UnitTests
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData("toKebabCase")]
        [InlineData("ToKebabCase")]
        [InlineData("to_kebab_case")]
        [InlineData("to-kebab-case")]
        public void ToKebabCaseTest(string str)
        {
            Assert.Equal("to-kebab-case", str.ToKebabCase());
        }
    }
}
