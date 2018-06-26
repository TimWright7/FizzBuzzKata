using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            //Arrange
            string input = "";
            int expected = 0;
            StringCalculator stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestCase("1",1)]
        [TestCase("2", 2)]
        [TestCase("999", 999)]
        public void Add_Given1Number_ShouldReturnNumber(string input,int expected)
        {
            //Arrange
            StringCalculator stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenNumber1And2_ShouldReturnSumOfNumbers()
        {
            //Arrange
            string input = "1,2";
            int expected = 3;
            StringCalculator stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenNumbers2And3_ShouldReturnSumOfNumbers()
        {
            //Arrange
            string input = "2,3";
            int expected = 5;
            StringCalculator stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenNumbers5And6_ShouldReturnSumOfNumbers()
        {
            //Arrange
            string input = "5,6";
            int expected = 11;
            StringCalculator stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenNumbers100And256_ShouldReturnSumOfNumbers()
        {
            //Arrange
            string input = "100,256";
            int expected = 356;
            StringCalculator stringCalculator = new StringCalculator();

            //Act
            var result = stringCalculator.Add(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
