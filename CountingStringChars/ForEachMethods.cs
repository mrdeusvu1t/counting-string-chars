using System;
using System.Collections.Generic;

#pragma warning disable CA1062

namespace CountingStringChars
{
    public static class ForEachMethods
    {
        public static int GetCharsCount(IEnumerable<char> str, Func<char, bool> func)
        {
            // TODO #4. Analyze the implementation of "GetCharsCountRecursive" methods, and implement the "GetCharsCount" method using the "foreach" loop statement.
            // The method should return a number of characters in the "str" parameter value that matches a certain criteria. Use func delegate for checking whether a character matches this criteria.
            throw new NotImplementedException();
        }

        public static int GetCharsCountRecursive(IEnumerable<char> str, Func<char, bool> func)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (func is null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            int counter = 0;
            GetCharsCountRecursive(str.GetEnumerator(), func, ref counter);

            return counter;
        }

        private static void GetCharsCountRecursive(IEnumerator<char> strEnumerator, Func<char, bool> func, ref int counter)
        {
            if (!strEnumerator.MoveNext())
            {
                return;
            }

            if (func(strEnumerator.Current))
            {
                counter++;
            }

            GetCharsCountRecursive(strEnumerator, func, ref counter);
        }
    }
}
