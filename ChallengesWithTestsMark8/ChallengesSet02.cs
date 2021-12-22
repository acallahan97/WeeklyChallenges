using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {

        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double minimum = 0;
            double maximum = 0;
            foreach (double item in numbers)
            {
                if (item < minimum)
                {
                    minimum = item;
                }
                else
                {
                    maximum = item;
                }
            }
            return maximum + minimum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum();

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return Math.Abs(numbers.Sum()) % 2 == 1;
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number >= 0)
            {
                return (number / 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
