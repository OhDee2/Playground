using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensions
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string input)
        {
            var characters = input.ToCharArray();
             var whatisthis = characters.Where(c => c != ' ').Select(c => c).ToArray().ToString();
            return characters.Select(c => c.ToString() != " ").ToString();
        }
    }
}
