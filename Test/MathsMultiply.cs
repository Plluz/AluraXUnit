using Xunit;

namespace AluraXUnit.Test
{
    public class MathsMultiply
    {
        readonly Maths _maths;

        public MathsMultiply() => _maths = new Maths();

        [Theory]
        [InlineData(16, new int[] { 8, 2 })]
        [InlineData(-25, new int[] { 5, -5 })]
        [InlineData(120, new int[] { 2, 3, 4, 5 })]
        public void Should_MultiplyEveryParameter_When_EveryParameterIsValid(int expected, int[] values)
        {
            // Act
            var result = 1;
            foreach (var value in values)
                result = _maths.Multiply(result, value);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}