using System;
using System.Collections.Generic;
using ChoreBoard.Utility.Extensions;
using Xunit;

namespace ChoreBoard.Utility.Tests.Extensions
{
    public class EnumerableExtensionsTests
    {
        public class IsNullOrEmptyMethod
        {
            [Theory]
            [InlineData(null)]
            public void ReturnsTrueWhenPassedNullValue<T>(IEnumerable<T> enumerable)
            {
                bool result = enumerable.IsNullOrEmpty();

                Assert.True(result);
            }

            [Fact]
            public void ReturnsTrueForZeroLengthArray()
            {
                int[] array = new int[0];

                bool result = array.IsNullOrEmpty();

                Assert.True(result);
            }

            [Fact]
            public void ReturnsTrueForEmptyCollection()
            {
                List<int> list = new List<int>(10);

                bool result = list.IsNullOrEmpty();

                Assert.True(result);
            }

            [Fact]
            public void ReturnsFalseForNonZeroLengthArray()
            {
                int[] array = new int[1];

                bool result = array.IsNullOrEmpty();

                Assert.False(result);
            }

            [Fact]
            public void ReturnsFalseWhenCollectionContainsElements()
            {
                List<int> list = new List<int> { 0 };

                bool result = list.IsNullOrEmpty();

                Assert.False(result);
            }
        }
    }
}
