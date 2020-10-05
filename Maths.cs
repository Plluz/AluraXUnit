using System.Linq;

namespace AluraXUnit
{
    public class Maths
    {
        public int Sum(params int[] numbers)
        {
            var total = 0;

            foreach (var number in numbers)
                total += number;

            return total;
        }

        public int Multiply(params int[] numbers)
        {
            var total = 0;

            foreach (var number in numbers)
                total *= number;

            return total;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}