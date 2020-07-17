using System;

namespace CountChars
{
    public static class WhileMethods
    {
        public static int GetSpaceCount(string str)
        {
            // TODO #2. Analyze the implementation of "GetSpaceCountRecursive" method, and implement the "GetSpaceCount" method using the "while" loop statement.
            // The method should return a number of spaces in the "str" parameter value.
            throw new NotImplementedException();
        }

        public static int GetSpaceCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            var result = GetSpaceCountRecursive(str[1..]) + (char.IsWhiteSpace(str[0]) ? 1 : 0);

            return result;
        }
    }
}
