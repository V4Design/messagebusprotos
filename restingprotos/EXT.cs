using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace v4demo_simulation_rest
{
    public class EXT
    {
    }

    public static class EnumerableExtension {
        public static T PickRandom<T>(this IEnumerable<T> source) {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count) {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source) {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}
