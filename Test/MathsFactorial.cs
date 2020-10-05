using Xunit;

namespace AluraXUnit.Test
{
    public class MathsFactorial
    {
        readonly Maths _maths;

        public MathsFactorial() => _maths = new Maths();

        [Theory]
        [InlineData(24, 4)]
        [InlineData(120, 5)]
        [InlineData(3628800, 10)]
        public void Should_ReturnFactorial_When_ParameterIsValid(int expected, int value)
        {
            // Act
            var result = _maths.Factorial(value);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
