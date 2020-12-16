using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //int nextNumber = startNumber;
            if (startNumber%n==0)
            {
                startNumber += 1;
                while (startNumber%n!=0)
                {
                    startNumber++;
                }
            }
            while (startNumber%n!=0)
            {
                startNumber++;
                
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                     businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {

                if(numbers[i]<numbers[i-1])
                {
                    return false;
                }
            }return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers==null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                
                 if (i==numbers.Length-1)
                {
                    return sum;
                }
                else if (numbers[i] %2 == 0)
                {
                    sum += numbers[i + 1];
                }
                
            }return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
