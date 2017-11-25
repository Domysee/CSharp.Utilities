using System;
using System.Collections.Generic;
using System.Text;

namespace DW.CSharp.Utilities
{
    public class LambdaEqualityComparer<T> : IEqualityComparer<T>
    {
        private Func<T, T, bool> equals { get; set; }
        private Func<T, int> getHashCode { get; set; }

        public LambdaEqualityComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
        {
            if (equals == null) throw new ArgumentNullException(nameof(equals));
            if (getHashCode == null) throw new ArgumentNullException(nameof(getHashCode));

            this.equals = equals;
            this.getHashCode = getHashCode;
        }

        public bool Equals(T x, T y) => equals(x, y);
        public int GetHashCode(T obj) => getHashCode(obj);
    }
}
