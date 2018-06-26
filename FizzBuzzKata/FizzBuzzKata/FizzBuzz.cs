using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string FizzBuzzer(int input)
        {
            if (NumberDivisibleBy3(input) && NumberDivisibleBy5(input))
            {
                return "FizzBuzz";
            }

            if (NumberDivisibleBy5(input))
            {
                return "Buzz";
            }

            if (NumberDivisibleBy3(input))
            {
                return "Fizz";
            }

            return input.ToString();
        }

        private static bool NumberDivisibleBy3(int input)
        {
            return input % 3 == 0;
        }

        private static bool NumberDivisibleBy5(int input)
        {
            return input % 5 == 0;
        }
    }
}
