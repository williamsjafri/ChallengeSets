using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int odd=0;
            int even = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }
            }
            return even - odd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list =new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int sum1 = sideLength1 + sideLength2;
            int sum2 = sideLength1 + sideLength3;
            int sum3 = sideLength2 + sideLength3;
            if (sum1>sideLength3 && sum2>sideLength2 && sum3>sideLength1 )
            {
                return true ;
            }return false;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
           
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int numberOfNull = 0;
            for (int i = 0; i < objs.Length; i++)
            {
             if (objs[i] == null)
              {
                    numberOfNull ++;
              }
            }
            if (numberOfNull>objs.Length/2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers==null||numbers.Length ==0)
            {
                return 0;
            }
            double evens = 0;
            double count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2==0)
                {
                    evens += numbers[i];
                    count++;
                }
                else
                {
                    evens += 0;
                    count += 0;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return evens / count;
        }

        public int Factorial(int number)
        {
            int results= 1;
            if (number==0)
            {
                return 1;
            }
            while(number>1)
            {
                results *= number;
                number -= 1;
            }return results;
        }
    }
}
