using System;

namespace CountingStringChars
{
    public static class DoWhileMethods
    {
        public static int GetNumbersCount(string str)
        {
            // TODO #3. Analyze the implementation of "GetNumbersCountRecursive" methods, and implement the "GetNumbersCount" method using the "do..while" loop statement.
            // The method should return a number of number characters in the "str" parameter value.
            throw new NotImplementedException();
        }

        public static int GetNumbersCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetNumbersCountRecursive(str, str.Length, 0);
        }

        private static int GetNumbersCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetNumbersCountRecursive(str, charsLeft - 1, char.IsDigit(str[^charsLeft]) ? ++counter : counter);
            }

            return counter;
        }
    }
}
