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
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
