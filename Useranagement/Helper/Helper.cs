using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Useranagement.Helper
{
    public static class Helper
    {
        public static string RandomString(int size)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
            Enumerable.Repeat(chars, size)
                  .Select(s => s[random.Next(s.Length)])
                  .ToArray());
            return result;
        }
    }
}
