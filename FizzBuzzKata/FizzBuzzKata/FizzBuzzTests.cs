using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzKata
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(4,"4")]
        public void FizzBuzzer_GivenNumber_ShouldReturnNumber(int input, string expected)
        {
            //Arrange     
            var systemUnderTest= new FizzBuzz();

            //Act
            var result = systemUnderTest.FizzBuzzer(input);

            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestCase(3,"Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        public void FizzBuzzer_GivenNumberDivisibleBy3_ShouldReturnFizz(int input, string expected)
        {
            //Arrange
            var systemUnderTest = new FizzBuzz();

            //Act
            var result = systemUnderTest.FizzBuzzer(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
       
        [TestCase(5,"Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        public void FizzBuzzer_GivenNumberDivisibleBy5_ShouldReturnBuzz(int input,string expected)
        {
            //Arrange
            var systemUnderTest = new FizzBuzz();

            //Act
            var result = systemUnderTest.FizzBuzzer(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        
        [TestCase(15,"FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(75, "FizzBuzz")]
        public void FizzBuzzer_GivenNumberDivisibleBy3And5_ShouldReturnFizzBuzz(int input, string expected)
        {
            //Arrange
            var systemUnderTest = new FizzBuzz();

            //Act
            var result = systemUnderTest.FizzBuzzer(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
       
    }
}
