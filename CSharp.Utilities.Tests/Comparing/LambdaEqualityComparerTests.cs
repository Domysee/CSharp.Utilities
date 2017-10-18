using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace CSharp.Utilities.Tests.Comparing
{
    public class LambdaEqualityComparerTests
    {
        [Fact]
        public void LambdaEqualityComparer_ShouldThrowException_IfEqualsParameterIsNull()
        {
            Action act = () =>
            {
                new LambdaEqualityComparer<string>(null, s => s.GetHashCode());
            };

            act.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void LambdaEqualityComparer_ShouldThrowException_IfGetHashCodeParameterIsNull()
        {
            Action act = () =>
            {
                new LambdaEqualityComparer<string>((s1, s2) => s1 == s2, null);
            };

            act.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void LambdaEqualityComparer_ShouldInvokeEqualsParameter_IfEqualsIsCalled()
        {
            var called = false;
            var comparer = new LambdaEqualityComparer<string>((s1, s2) =>
            {
                called = true;
                return s1 == s2;
            }, s => s.GetHashCode());

            comparer.Equals("s1", "s2");

            called.Should().BeTrue();
        }

        [Fact]
        public void LambdaEqualityComparer_ShouldInvokeGetHashCodeParameter_IfGetHashCodeIsCalled()
        {
            var called = false;
            var comparer = new LambdaEqualityComparer<string>((s1, s2) => s1 == s2, s =>
            {
                called = true;
                return s.GetHashCode();
            });

            comparer.GetHashCode("s");

            called.Should().BeTrue();
        }
    }
}
