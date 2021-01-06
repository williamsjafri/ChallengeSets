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
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
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
