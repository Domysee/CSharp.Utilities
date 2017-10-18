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
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            return enumerable.Concat(new[] { addObject });
        }
    }
}
