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
            Assert.Equal(10, _maths.Sum(5, 5));
        }

        [Fact]
        public void MultiplicationWorks()
        {
            Assert.Equal(25, _maths.Multiply(5, 5));
        }
    }
}