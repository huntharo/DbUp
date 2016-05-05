using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUp.Helpers
{
    public static class StringExtensions
    {
#if NETPCL
        public static int Count(this string list, Func<char, bool> predicate)
        {
            int count = 0;
            foreach (var i in list)
            {
                if (predicate(i)) count++;
            }

            return count;
        }
#endif
    }
}
