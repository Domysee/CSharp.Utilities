using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DW.CSharp.Utilities.Collection
{
    public static class IEnumerableExtensionMethods
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> enumerable, T value)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            return enumerable.Concat(new[] { value });
        }

        public static IEnumerable<T> Except<T>(this IEnumerable<T> enumerable, T value)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            return enumerable.Except(new[] { value });
        }

        public static IEnumerable<T> RemoveNulls<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Where(v => v != null);
        }
    }
}
