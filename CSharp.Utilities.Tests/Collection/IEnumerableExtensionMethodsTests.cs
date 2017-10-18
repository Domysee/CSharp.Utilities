using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Utilities.Collection;
using FluentAssertions;
using Xunit;

namespace CSharp.Utilities.Tests.Collection
{
    public class IEnumerableExtensionMethodsTests
    {
        [Fact]
        public void ExtensionMethodAdd_ShouldReturnNewIEnumerable_IfCorrectParameters()
        {
            var enumerable = Enumerable.Empty<string>();
            var addObject = "s";

            var newEnumerable = enumerable.Add(addObject);

            newEnumerable.Should().NotBeSameAs(enumerable);
        }

        [Fact]
        public void ExtensionMethodAdd_ShouldAddObject_IfCorrectParameters()
        {
            var enumerable = Enumerable.Empty<string>();
            var addObject = "s";

            var newEnumerable = enumerable.Add(addObject);

            newEnumerable.Should().Contain(addObject);
        }

        [Fact]
        public void ExtensionMethodAdd_ShouldAddObjectOnce_IfCorrectParameters()
        {
            var enumerable = Enumerable.Empty<string>();
            var addObject = "s";

            var newEnumerable = enumerable.Add(addObject);

            newEnumerable.Should().HaveCount(enumerable.Count() + 1);
        }

        [Fact]
        public void ExtensionMethodAdd_ShouldAddNull_IfNullIsGiven()
        {
            var enumerable = Enumerable.Empty<string>();
            string addObject = null;

            var newEnumerable = enumerable.Add(addObject);

            newEnumerable.Should().Contain(addObject);
        }

        [Fact]
        public void ExtensionMethodAdd_ShouldThrow_IfIEnumerableIsNull()
        {
            IEnumerable<string> enumerable = null;
            var addObject = "s";

            Action act = () => enumerable.Add(addObject);

            act.Should().ThrowExactly<ArgumentNullException>();
        }
    }
}
