using Calculator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class Subtraction
    {
        private readonly IMath _math;

        public Subtraction()
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
            int expected = -1;
            int i = 1;
            int j = 2;

            //Act
            int result = _math.Subtraction(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSmallNegativeNumbers()
        {
            //Arrange
            int expected = 1;
            int i = -1;
            int j = -2;

            //Act
            int result = _math.Subtraction(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargePositiveNumbers()
        {
            //Arrange
            int expected = -8799244;
            int i = 89876434;
            int j = 98675678;

            //Act
            int result = _math.Subtraction(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargeNegativeNumbers()
        {
            //Arrange
            int expected = 8799244;
            int i = -89876434;
            int j = -98675678;

            //Act
            int result = _math.Subtraction(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSmallPositiveAndNegativeNumbers()
        {
            //Arrange
            int expected = -3;
            int i = -1;
            int j = 2;

            //Act
            int result = _math.Subtraction(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLargePositiveAndNegativeNumbers()
        {
            //Arrange
            int expected = 188552112;
            int i = 89876434;
            int j = -98675678;

            //Act
            int result = _math.Subtraction(i, j);

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
            int result = _math.Subtraction(i, j);

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
            int result = _math.Subtraction(i, j);

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
            int result = _math.Subtraction(i, j);

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
            int result = _math.Subtraction(i, j);

            //Assert 
            Assert.AreNotEqual(expected, result);
        }

        #endregion
    }
}
