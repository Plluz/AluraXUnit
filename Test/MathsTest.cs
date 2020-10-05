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

        [Fact]
        public void MultiplicationWorks()
        {
            // Arrange
            var values = new int[] { 5, 5 };

            // Act
            var result = _maths.Multiply(values);

            // Assert
            var expected = 25;
            Assert.Equal(expected, result);
        }
    }
}