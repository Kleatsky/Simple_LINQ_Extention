using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simple_LINQ_ExtentionConsole
{
    internal static class LINQ_Top_Extesion
    {
        internal static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
        {
            if (collection is null || collection.Count() == 0) return collection;
            if (percent < 0 || percent >= 101) throw new ArgumentException();


            return collection;
        }
    }
}
