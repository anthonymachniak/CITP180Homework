using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestClass()]
        public class PropertyValueCalculator
        {
            [TestMethod()]
            public void StandardInputTest()
            {
                //arrange
                double previousPropertyValue = 100000;
                double expected = 102700;

                //act
                double actual = Program.PropertyValueCalculator(previousPropertyValue);

                //assert
                Assert.AreEqual(expected, actual);

            }

            [TestMethod()]
            public void NegativeInputTest()
            {
                //arrange
                double previousPropertyValue = -100000;
                double expected = -102700;

                //act
                double actual = Program.PropertyValueCalculator(previousPropertyValue);

                //assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestClass()]
        public class MillageCalculator
        {
            [TestMethod()]
            public void StandardInputTest()
            {
                //arrange
                double propertyValue = 100000;
                double expected = 1003;

                //act
                double actual = Program.MillageCalculator(propertyValue);

                //assert
                Assert.AreEqual(expected, Math.Round(actual, 0));
            }

            [TestMethod()]
            public void NegativeInputTest()
            {
                //arrange
                double previousPropertyValue = -100000;
                double expected = -1003;

                //act
                double actual = Program.MillageCalculator(previousPropertyValue);

                //assert
                Assert.AreEqual(expected, Math.Round(actual, 0));
            }

        }
    }
}