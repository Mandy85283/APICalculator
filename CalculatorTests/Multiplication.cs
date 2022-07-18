using Calculator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class Multiplication
    {
        private readonly IMath _math;

        public Multiplication()
        {
            var services = new ServiceCollection();
            services.AddTransient<IMath, Math>();
            var serviceProvider = services.BuildServiceProvider();
            _math = serviceProvider.GetService<IMath>();
        }

        #region positive test cases

        [TestMethod]
        public void TestSmallPositiveNumbers()
        {
            //Arrange
            int expected = 2;
            int i = 1;
            int j = 2;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSmallNegativeNumbers()
        {
            //Arrange
            int expected = 2;
            int i = -1;
            int j = -2;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargePositiveNumbers()
        {
            //Arrange
            int expected = 100000000;
            int i = 10000;
            int j = 10000;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargeNegativeNumbers()
        {
            //Arrange
            int expected = 100000000;
            int i = -10000;
            int j = -10000;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSmallPositiveAndNegativeNumbers()
        {
            //Arrange
            int expected = -2;
            int i = -1;
            int j = 2;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargePositiveAndNegativeNumbers()
        {
            //Arrange
            int expected = -100000000;
            int i = 10000;
            int j = -10000;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        #endregion

        #region negative test cases

        [TestMethod]
        public void TestPositiveAndNegativeNumbers()
        {
            //Arrange
            int expected = 2000;
            int i = -2500;
            int j = 1200;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestPositiveNumbers()
        {
            //Arrange
            int expected = 2000;
            int i = 2500;
            int j = 1200;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestNegativeNumbers()
        {
            //Arrange
            int expected = 2000;
            int i = -2500;
            int j = -1200;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestMixedNumbers()
        {
            //Arrange
            int expected = 2000;
            int i = 2500;
            int j = -1200;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreNotEqual(expected, result);
        }

        #endregion
    }
}
