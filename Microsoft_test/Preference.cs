using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft_test
{
    public static class Preference
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
