using System;

namespace CountChars
{
    public static class ForMethods
    {
        public static int GetCharsCount(string str)
        {
            // TODO #1. Analyze the implementation of "GetCharsCountRecursive" methods, and implement the "GetCharsCount" method using the "for" loop statement.
            // The method should return a number of all characters in the "str" parameter value.
            throw new NotImplementedException();
        }

        public static int GetCharsCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharsCountRecursive(str, 0);
        }

        private static int GetCharsCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharsCountRecursive(str, index + 1) + 1;
        }
    }
}
