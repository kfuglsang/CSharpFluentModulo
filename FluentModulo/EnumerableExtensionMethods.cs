using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModulo
{
    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<T> ForEvery<T>(this IEnumerable<T> source, int every, Action<T> action)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (every == 0)
                throw new ArgumentException("every");

            if (action == null)
                throw new ArgumentNullException("action");

            foreach (var item in source.Every(every))
                action(item);

            return source;
        }

        public static IEnumerable<T> Every<T>(this IEnumerable<T> source, int every)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (every <= 0)
                throw new ArgumentException("every");

            var index = 1;
            foreach (var item in source)
            {
                if (index > 0 && index % every == 0)
                    yield return item;

                index++;
            }
        }
    }
}
