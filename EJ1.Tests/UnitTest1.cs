using System;
using Xunit;
using EJ1;

namespace EJ1.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 2, 5)]
        [InlineData(-10, 5, -2)]
        [InlineData(5, -3, -1.66666666666666667)]
        [InlineData(4.25, 1.25, 3.4)]
        [InlineData(0, 1.25, 0)]
        [InlineData(4.25, 0, 0)]
        [InlineData(0, 0, 0)]
        public void Division_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange


            //Act
            double actual = Matematica.Dividir(x, y);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
