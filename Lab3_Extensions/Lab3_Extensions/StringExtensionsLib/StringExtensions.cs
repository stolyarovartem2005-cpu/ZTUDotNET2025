using System;

namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        // Інвертування рядка
        public static string ReverseString(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Підрахунок кількості входжень символа
        public static int CountOccurrences(this string value, char symbol)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            int count = 0;
            foreach (char c in value)
            {
                if (c == symbol)
                    count++;
            }

            return count;
        }
    }
}
