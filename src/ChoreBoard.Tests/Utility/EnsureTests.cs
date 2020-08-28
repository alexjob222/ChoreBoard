using ChoreBoard.Utility;
using System;
using Xunit;

namespace ChoreBoard.Tests.Utility
{
    public class EnsureTests
    {
        public class ArgumentNotNullMethod
        {
            [Fact]
            public void ThrowsExceptionWhenArgumentIsNull()
            {
                string arg = null;

                Action act = () => Ensure.ArgumentNotNull(arg, nameof(arg));

                Assert.Throws<ArgumentNullException>(act);
            }
        }

        public class ArgumentConditionMethod
        {
            [Fact]
            public void ThrowsExceptionWhenConditionIsFalse()
            {
                bool condition = false;
                string msg = "error message";

                Action act = () => Ensure.ArgumentCondition(condition, nameof(condition), msg);

                Assert.Throws<ArgumentException>(act);
            }
        }

        public class IsNotNullMethod
        {
            [Fact]
            public void ThrowsExceptionWithMessageWhenValueIsNull()
            {
                object value = null;
                string msg = "Value cannot be null";

                Action act = () => Ensure.IsNotNull(value, msg);

                var exception = Assert.Throws<InvalidOperationException>(act);
                Assert.Equal(msg, exception.Message);
            }
        }

        public class IsFalseMethod
        {
            [Fact]
            public void ThrowsExceptionWithMessageWhenConditionIsTrue()
            {
                bool condition = true;
                string msg = "Condition should be false";

                Action act = () => Ensure.IsFalse(condition, msg);

                var exception = Assert.Throws<InvalidOperationException>(act);
                Assert.Equal(msg, exception.Message);
            }
        }

        public class IsTrueMethod
        {
            [Fact]
            public void ThrowsExceptionWithMessageWhenConditionIsFalse()
            {
                bool condition = false;
                var msg = "expected message";

                Action act = () => Ensure.IsTrue(condition, msg);

                var exception = Assert.Throws<InvalidOperationException>(act);
                Assert.Equal(msg, exception.Message);
            }
        }
    }
}
