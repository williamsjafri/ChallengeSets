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
                       
            string str = "";
            if (words == null || words.Length < 1)
                return str;
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;
                else
                    str += word.Trim() + " ";
            }
            if (str == "")
            {
                return "";
            }
            return str.TrimEnd() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var list = new List<double>();
            if (elements==null||elements.Count==0)
            {
                return new double[0] ;
            }
            for (int i = 3; i < elements.Count; i+=4)
            {
                list.Add(elements[i]);
            }return list.ToArray();
            
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            if (nums==null||nums.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j]==targetNumber && i!=j)
                    {
                        return true;
                    }
                    
                }
                
            }return false;
            
        }
    }
}
