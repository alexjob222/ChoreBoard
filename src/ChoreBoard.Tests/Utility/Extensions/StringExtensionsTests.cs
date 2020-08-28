using ChoreBoard.Utility.Extensions;
using System;
using Xunit;

namespace ChoreBoard.Tests.Utility.Extensions
{
    public class StringExtensionsTests
    {
        public class EqualsIgnoreCaseMethod
        {
            [Theory]
            [InlineData(null, null)]
            public void ReturnsTrueForTwoNullValues(string input, string compareTo)
            {
                bool result = input.EqualsIgnoreCase(compareTo);

                Assert.True(result);
            }

            [Theory]
            [InlineData("test", "TEST")]
            [InlineData("<>123.abc", "<>123.AbC")]
            public void IsCaseInsensitive(string input, string compareTo)
            {
                bool result = input.EqualsIgnoreCase(compareTo);

                Assert.True(result);
            }

            [Theory]
            [InlineData("", null)]
            [InlineData("", " ")]
            [InlineData("bbac123", "bbca123")]
            [InlineData("é", "e")]
            public void ReturnsFalseForDifferentValues(string input, string compareTo)
            {
                bool result = input.EqualsIgnoreCase(compareTo);

                Assert.False(result);
            }
        }

        public class DefaultToMethod
        {
            [Theory]
            [InlineData(null, "default")]
            [InlineData("", "abc")]
            [InlineData("\t\r\n", "123")]
            public void ReturnsDefaultValueWhenInputIsBlank(string input, string defaultValue)
            {
                string expected = defaultValue;
                string result = input.DefaultTo(defaultValue);

                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData("a", "1")]
            [InlineData("\t123", "123")]
            public void ReturnsInputWhenItIsNotWhiteSpace(string input, string defaultValue)
            {
                string expected = input;
                string result = input.DefaultTo(defaultValue);

                Assert.Equal(expected, result);
            }
        }
    }
}
