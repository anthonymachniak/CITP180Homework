using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestClass()]
        public class CalculatePerimeterMethodTests
        {
            [TestMethod()]
            public void IntendedInputTest()
            {
                //arrange
                double height = 2;
                double width = 2;
                double expected = 8;

                //act
                double actual = Program.CalculatePerimeter(height, width);

                //assert
                Assert.AreEqual(expected, actual);
            }
            
            [TestMethod()]
            public void NegativeInputTest()
            {
                //arrange
                double height = -2;
                double width = 2;
                double expected = 0;

                //act
                double actual = Program.CalculatePerimeter(height, width);

                //assert
                Assert.AreEqual(expected, actual);
            }
        }
        
        [TestClass()]
        public class CalculateAreaMethodTests
        {
            [TestMethod()]
            public void IntendedInputTest()
            {
                //arrange
                double height = 2;
                double width = 2;
                double expected = 4;

                //act
                double actual = Program.CalculateArea(height, width);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod()]
            public void NegativeInputTest()
            {
                //arrange
                double height = -2;
                double width = 2;
                double expected = -4;

                //act
                double actual = Program.CalculateArea(height, width);

                //assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}