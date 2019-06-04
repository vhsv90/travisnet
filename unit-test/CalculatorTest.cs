using services;
using System;
using Xunit;

namespace unit_test
{
    public class CalculatorTest
    {
        public Calculator calculator;

        public CalculatorTest()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void SumOperation()
        {
            int num1 = 10;
            int num2 = 40;
            
            int resultValidated = 50;

            var result = calculator.Sum(num1, num2);

            Assert.True(result == resultValidated);
        }

        [Fact]
        public void SubOperation()
        {
            int num1 = 40;
            int num2 = 10;
            
            int resultValidated = 30;

            var result = calculator.Sub(num1, num2);

            Assert.True(result == resultValidated);
        }

    }
}
