using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
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
            var total = 1;

            foreach (var number in numbers)
                total *= number;

            return total;
        }

        public int Factorial(int number)
        {
            var result = 1;

            for (int i = number; i > 0; i--)
                result *= i;

            return result;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}