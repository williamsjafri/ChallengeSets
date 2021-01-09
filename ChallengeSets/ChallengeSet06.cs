using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words==null)
            {
                return false;
            }
            List<string> wordList = words.ToList();           
            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i]==null)
                {
                    return false;
                }
                else if (ignoreCase==true)
                {
                    if (wordList[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        return true;
                    }
                    
                    
                }
                else if (wordList[i]==word && ignoreCase == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 1 || num<=0 )
            { return false; }
            if (num == 2){ return true; }

            var limit = Math.Ceiling(Math.Sqrt(num));

            for (int i = 2; i <= limit; ++i)
                if (num % i == 0)
                { return false; }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                
                
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i]==str[j])
                    {
                        arr[i]++;
                    }
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            { 
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i]==1 && arr[i] == arr[j] && i<j)
                    {
                        return j;
                    }
                }
                if (arr[i] == 1)
                {
                    
                    return i;
                }
                
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
