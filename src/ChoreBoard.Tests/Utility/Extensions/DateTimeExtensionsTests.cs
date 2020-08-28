using ChoreBoard.Utility.Extensions;
using System;
using Xunit;

namespace ChoreBoard.Tests.Utility.Extensions
{
    public class DateTimeExtensionsTests
    {
        public class HasValueMethod
        {
            [Fact]
            public void ReturnsFalseForDateTimeMinValue()
            {
                var dateTime = DateTime.MinValue;

                bool result = dateTime.HasValue();

                Assert.False(result);
            }

            [Fact]
            public void ReturnsFalseForNullValue()
            {
                DateTime? dateTime = null;

                bool result = dateTime.HasValue();

                Assert.False(result);
            }

            [Fact]
            public void ReturnsTrueForDateTimeMaxValue()
            {
                var dateTime = DateTime.MaxValue;

                bool result = dateTime.HasValue();

                Assert.True(result);
            }

            [Fact]
            public void ReturnsTrueIfValueIsNotDateTimeMinValue()
            {
                DateTime dateTime = DateTime.MinValue.AddSeconds(1);

                bool result = dateTime.HasValue();

                Assert.True(result);
            }
        }
    }
}
