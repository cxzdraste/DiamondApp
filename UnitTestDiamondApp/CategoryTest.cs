using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDiamondApp
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void CategoryNullTest()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                var category = new CategoryClass("Кольцо");
            });
        }
    }
}
