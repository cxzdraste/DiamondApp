using System;
using System.Security.Cryptography;
using System.Text;

namespace DiamonApp.Hash
{
    public class SimpleHash
    {
        public static string HashSHA256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                var sb = new StringBuilder();
                foreach (var b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}