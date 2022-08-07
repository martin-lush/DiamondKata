using System;
using System.Linq;

namespace DiamondKata.Tests.Extensions
{
    public static class StringExtensions
    {
        public static string? RemoveWhitespace(this string input)
        {
            return new string(input?.Where(c => c != ' ').ToArray());
        }

        public static string? RemoveNewLines(this string input)
        {
            return input?.Replace(Environment.NewLine, string.Empty);
        }

        public static string? RemoveWhitespaceAndNewLines(this string input)
        {
            return input.RemoveWhitespace()?.RemoveNewLines();
        }
    }
}
