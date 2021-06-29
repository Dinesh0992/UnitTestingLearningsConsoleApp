using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        public TestContext TestContext { get; set; }
        [TestMethod()]
        [TestCategory("Postive")]
        [Priority(1)]
        [TestProperty("InputType", "Parameterless")]
        [Owner("Dinesh")]
        public void Add_PostiveNumbers_ReturnSumofPositiveNumbers()
        {
            int expected = 3;

            int actual = Calculator.Add(1, 2);
            Assert.AreEqual(expected, actual);
            TestContext.WriteLine(TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine(TestContext.TestName);
        }

        [TestMethod()]
        [TestCategory("Postive")]
        [TestProperty("InputType", "Parameterless")]
        [Priority(2)]
        public void Add_LargerPostiveSmallerNegativeNumbers_ReturnofPositiveNumbers()
        {
            // int expected = 1;

            int actual = Calculator.Add(3, -2);
            Assert.IsTrue(actual > 0);
        }
        [TestMethod()]
        [DataRow(2, -3)]
        [DataRow(1, -4)]
        [TestCategory("Negative"), TestCategory("Parameterized")]
        [Priority(1)]
        public void Add_SmallerPostiveLargerNegativeNumbers_ReturnofNegativeNumbers(int x, int y)
        {
            // int expected = 1;

            int actual = Calculator.Add(x, y);
            Assert.IsTrue(actual < 0);
        }

        [TestCleanup]
        public void testcleanup()
        {
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());

        }
    }
}