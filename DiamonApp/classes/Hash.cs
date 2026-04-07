using System;
using System.Security.Cryptography;
using System.Text;

namespace DiamondApp.Hash
{
    public class SimpleHash
    {
        public static string HashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create()) 
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = sha256.ComputeHash(bytes);
                var sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));  
                }
                return sb.ToString();
            }
        }
    }
}