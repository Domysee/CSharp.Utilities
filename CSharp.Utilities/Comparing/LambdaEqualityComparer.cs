using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Utilities
{
    public class LambdaEqualityComparer<T> : IEqualityComparer<T>
    {
        private Func<T, T, bool> equals { get; set; }
        private Func<T, int> getHashCode { get; set; }

        public LambdaEqualityComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
        {
            this.equals = equals;
            this.getHashCode = getHashCode ?? (obj => obj.GetHashCode());
        }

        public bool Equals(T x, T y) => equals(x, y);
        public int GetHashCode(T obj) => getHashCode(obj);
    }
}
