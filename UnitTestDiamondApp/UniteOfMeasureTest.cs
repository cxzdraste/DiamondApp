using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDiamondApp
{
    public class UniteOfMeasureTest
    {
        public void UniteOfMeasureUnitTest()
        {
            string unit = "test";
            var result = new UniteOfMeasureClass(unit);
            Assert.IsNotNull(result.UnitesOfMeasure);
            Assert.AreEqual(1, result.UnitesOfMeasure.Count);
            Assert.AreEqual("test", result.UnitesOfMeasure[0]);
        }
    }
}
