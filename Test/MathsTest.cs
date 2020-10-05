using Xunit;

namespace AluraXUnit.Test
{
    public class MathsTest
    {
        readonly Maths _maths;

        public MathsTest() => _maths = new Maths();

        [Theory]
        [InlineData(10, new int[] { 5, 5 })]
        [InlineData(14, new int[] { 20, -6 })]
        [InlineData(17, new int[] { 10, 2, 5 })]
        public void SumWorks(int expected, int[] values)
        {
            // Act
            var result = 0;
            foreach (var value in values)
                result = _maths.Sum(result, value);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(16, new int[] { 8, 2 })]
        [InlineData(-25, new int[] { 5, -5 })]
        [InlineData(120, new int[] { 2, 3, 4, 5 })]
        public void MultiplicationWorks(int expected, int[] values)
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