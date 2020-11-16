using System;
using System.Collections.Generic;

namespace PrimeFactorsTask
{
    public static class PrimeFactors
    {
        /// <summary>
        /// Compute the prime factors of a given natural number.
        /// A prime number is only evenly divisible by itself and 1.
        /// Note that 1 is not a prime number.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Prime factors of a given natural number.</returns>
        /// <exception cref="ArgumentException">Thrown when number less or equal 0.</exception>
        /// <example>
        /// 60 => {2, 2, 3, 5}
        /// 8 => {2, 2, 2}
        /// 12 => {2, 2, 3}
        /// 901255 => {5, 17, 23, 461}
        /// 93819012551 => {11, 9539, 894119}.
        /// </example>
        public static int[] GetFactors(long number)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{number} cannot be less or equals zero.");
            }

            List<int> result = new List<int>();
            var divider = 2;
            while (divider * divider <= number)
            {
                if (number % divider == 0)
                {
                    result.Add(divider);
                    number /= divider;
                }
                else
                {
                    divider++;
                }
            }

            if (number > 1)
            {
                result.Add((int)number);
            }

            return result.ToArray();
        }
    }
}
