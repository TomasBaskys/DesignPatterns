using System;

namespace Template
{
    public static class StringArrayExtensions
    {
        public static string ToStringEx(this string[] array)
        {
            string value = String.Empty;

            foreach (var item in array)
            {
                value += $"{item}, ";
            }

            return value;
        }
    }
}