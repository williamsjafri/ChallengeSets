﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {

            if (char.IsLetter(c))
            {
                return true;
            } return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2==0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2==0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num%2==1||num%2==-1)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null ||numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            

            if (str1.Length >str2.Length )
            {
                return str2.Length;
            } 
            return str1.Length ;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers==null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }    
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];

                    }

                }
            }
            return sum;
           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum=0;
            if (numbers == null)
            {
                return false ;
            }
            for (int i = 0; i < numbers.Count ; i++)
            {
                sum += numbers[i];
                    
            }
            if (sum % 2 == 1 || sum % 2 == -1)
            {
                return true;
            }
            return false;
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number<0)
            {
                return 0;
            } return number / 2;
        }
    }
}
