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
            if (collection is null || collection.Count() == 0) return collection!;
            if (percent < 0 || percent >= 101) throw new ArgumentException();

            double tempresult = (double)collection.Count() * (double)percent / 100.0;
            int newcount = (int)Math.Ceiling(tempresult);

            //Becouse round of 0 == 0, but we need atleast 1 value
            if (newcount == 0) newcount = 1;

            List<T> result = new List<T>(newcount);

            int i = 0;
            foreach (var item in collection.Reverse())
            {
                result.Add(item);
                i++;
                if (i == newcount) break;
            }
            return result;
        }
        internal static IEnumerable<T> Top<T, T2>(this IEnumerable<T> collection, int percent, Func<T, T2> predicate)
        {
            if (collection is null || collection.Count() == 0) return collection!;
            if (percent < 0 || percent >= 101) throw new ArgumentException();
            if (predicate == null) throw new ArgumentNullException();

            double tempresult = (double)collection.Count() * (double)percent / 100.0;
            int newcount = (int)Math.Ceiling(tempresult);

            //Becouse round of 0 == 0, but we need atleast 1 value
            if (newcount == 0) newcount = 1;

            List<T> result = new List<T>(newcount);

            var sortedCollection = collection.OrderBy(predicate);

            int i = 0;
            foreach (var item in sortedCollection.Reverse())
            {
                result.Add(item);
                i++;
                if (i == newcount) break;
            }
            return result;
        }
    }
}
