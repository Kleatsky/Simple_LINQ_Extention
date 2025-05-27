using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_LINQ_ExtentionConsole
{
    internal static class LINQ_Take_Extesion
    {
        internal static IEnumerable<T> Take<T>(this IEnumerable<T> collection, int count)
        {
            if (collection == null || collection.Count() == 0) return collection;
            if (count == 0) return null;
            if (count < 0 || collection.Count() < count) throw new ArgumentException();
            return collection.Take(count);
        }
    }
}
