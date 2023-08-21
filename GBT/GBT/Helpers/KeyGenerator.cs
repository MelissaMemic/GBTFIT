using System;

using System.Security.Cryptography;

namespace GBT.Helpers
{
    public class KeyGenerator
    {
        public static string GenerateKey(int length)
        {
            using var random = new RNGCryptoServiceProvider();
            var keyBytes = new byte[length];
            random.GetBytes(keyBytes);
            return Convert.ToBase64String(keyBytes);
        }
    }
}
