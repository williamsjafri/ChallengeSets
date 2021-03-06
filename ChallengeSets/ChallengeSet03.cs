﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length ; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
           return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers==null)
            {
                return false;
            }
            List<int> oddNumbers=new List<int>();
            foreach (var item in numbers )
            {
                if (item%2!=0)
                {
                    oddNumbers.Add(item);
                }
            }
            if (oddNumbers.Sum()%2!=0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            foreach (char item in password)
            {
                if (char.IsUpper(item))
                {
                    foreach (char item1 in password)
                    {
                        if (char.IsLower(item1))
                        {
                            foreach (char item2 in password)
                            {
                                if (char.IsDigit(item2))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
               
            }return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor==0)
            {
                return 0;
            }
            return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            var odds =new  List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i%2==1)
                {
                    odds.Add(i);
                }
            }return odds.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
       
            for (int i = 0; i < words.Length; i++)
            {
             words[i]=words[i].ToUpper();
            }
            
        }
    }
}
