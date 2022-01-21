using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {           
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return sum;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if ( i == numbers.Length - 1)
                {
                    break;
                }

                if ( numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length <= 0)
            {
                return "";
            }

            string finalSentence = "";
            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    finalSentence += word.Trim() + " ";
                }
            }
            if (finalSentence.Length == 0)
            {
                return string.Empty;
            }
            finalSentence = finalSentence.Substring(0, finalSentence.Length-1);
            finalSentence += ".";           
            return finalSentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> element = new List<double>();
            for (var i = 3; i < elements.Count; i+=4)
            {
                element.Add(elements[i]);
            }
            return element.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i+1; k < nums.Length; k++)
                {
                    if (nums[i]+nums[k]==targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
