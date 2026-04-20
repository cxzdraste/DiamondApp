using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDiamondApp
{
    public class HashTest
    {
        public void HashSHA256_ShouldReturnCorrectHash_ForKnownInput()
        {
            string input = "test";
            string expectedHash = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";
            string actualHash = YourClassName.HashSHA256(input);
            Assert.Equal(expectedHash, actualHash);
        }
    }
}
