using Xunit;

namespace AluraXUnit.Test
{
    public class MathsTest
    {
        readonly Maths _maths;

        public MathsTest() => _maths = new Maths();

        [Fact]
        public void SumWorks()
        {
            // Arrange
            var values = new int[] {5, 5};

            // Act
            var result = _maths.Sum(values);

            // Assert
            var expected = 10;
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