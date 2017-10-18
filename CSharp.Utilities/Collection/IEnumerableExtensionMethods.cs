using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Utilities.Collection
{
    public static class IEnumerableExtensionMethods
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> enumerable, T addObject)
        {
            return enumerable.Concat(new[] { addObject });
        }
    }
}
