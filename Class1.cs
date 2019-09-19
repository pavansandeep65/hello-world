using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwesomeCalculator;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorTest1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAddition_Input4point0and6point0_Returns10point0()
        {
            double num1 = 4;
            double num2 = 6;

            double expectedResult = num1 + num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetAddition();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input5point0and10point0_Returns15point0()
        {
            double num1 = 5;
            double num2 = 10;

            double expectedResult = num1 + num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetAddition();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input15and16_Returns31()
        {
            double num1 = 15;
            double num2 = 16;

            double expectedResult = num1 + num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetAddition();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input19and16_Returns3()
        {
            double num1 = 19;
            double num2 = 16;

            double expectedResult = num1 - num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetSubtraction();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input100and15_Returns85()
        {
            double num1 = 100;
            double num2 = 15;

            double expectedResult = num1 - num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetSubtraction();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input150and15_Returns135()
        {
            double num1 = 150;
            double num2 = 15;

            double expectedResult = num1 - num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetSubtraction();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input2point0and10point0_Returns20point0()
        {
            double num1 = 2;
            double num2 = 10;

            double expectedResult = num1 * num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetMultiplication();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input3point0and10point0_Returns30point0()
        {
            double num1 = 3;
            double num2 = 10;

            double expectedResult = num1 * num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetMultiplication();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input4point0and10point0_Returns40point0()
        {
            double num1 = 4;
            double num2 = 10;

            double expectedResult = num1 * num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetMultiplication();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input16and2_Returns8()
        {
            double num1 = 16;
            double num2 = 2;
            double expectedResult = num1 / num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetDivision();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input14and2_Returns7()
        {
            double num1 = 14;
            double num2 = 2;

            double expectedResult = num1 / num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetDivision();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input18point0and2point0_Returns9point0()
        {
            double num1 = 18;
            double num2 = 2;

            double expectedResult = num1 / num2;
            Calc testCalc = new Calc(num1, num2);

            double actualResult = testCalc.GetDivision();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
