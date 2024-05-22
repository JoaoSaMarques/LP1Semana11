using System.Collections.Generic;
using System.Linq;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            return items.Count(item => item is T);
        }
    }
}
