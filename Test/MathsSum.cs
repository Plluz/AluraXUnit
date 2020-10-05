using Xunit;

namespace AluraXUnit.Test
{
    public class MathsSum
    {
        readonly Maths _maths;

        public MathsSum() => _maths = new Maths();

        [Theory]
        [InlineData(10, new int[] { 5, 5 })]
        [InlineData(14, new int[] { 20, -6 })]
        [InlineData(17, new int[] { 10, 2, 5 })]
        public void Should_SumEveryParameter_When_EveryParameterIsValid(int expected, int[] values)
        {
            // Act
            var result = 0;
            foreach (var value in values)
                result = _maths.Sum(result, value);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}