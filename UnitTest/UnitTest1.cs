using FizzBuzzTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnNumber()
        {
            //Arrange
            string expectedResult = "1";

            // Act 
            string actualResult = FizzBuzz.FindFizzBuzz(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnFizz()
        {
            //Arrange
            string expectedResult = "Fizz";

            //Act
            string actualResult = FizzBuzz.FindFizzBuzz(3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnBuzz()
        {
            //Arrange
            string expectedResult = "Buzz";

            //Act
            string actualResult = FizzBuzz.FindFizzBuzz(5);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnFizzBuzz()
        {
            //Arrange
            string expectedResult = "FizzBuzz";

            //Act
            string actualResult = FizzBuzz.FindFizzBuzz(15);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnNumberTest2()
        {
            //Arrange
            string expectedResult = "7";

            // Act 
            string actualResult = FizzBuzz.FindFizzBuzz(7);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnFizzTest2()
        {
            //Arrange
            string expectedResult = "Fizz";

            //Act
            string actualResult = FizzBuzz.FindFizzBuzz(33);
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnBuzzTest2()
        {
            //Arrange
            string expectedResult = "Buzz";

            //Act
            string actualResult = FizzBuzz.FindFizzBuzz(80);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnFizzBuzzTest2()
        {
            //Arrange
            string expectedResult = "FizzBuzz";

            //Act
            string actualResult = FizzBuzz.FindFizzBuzz(60);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}