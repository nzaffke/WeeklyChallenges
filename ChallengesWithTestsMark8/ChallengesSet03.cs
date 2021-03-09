using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == false)
                {
                    return true;
                }
            }
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            if( numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char c = val.FirstOrDefault();
                return c;
        }

        public char GetLastLetterOfString(string val)
        {
            char last_char = val[val.Length - 1];
            return last_char;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            int[] numbers1 = new int[numbers.Count];
            for (int j = 0; j < numbers.Count; j++)
            {
                numbers1[j] = numbers[j];
            }
            return numbers1;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //for(int i = 0; i < words.Length; i++)
            //{
            //    words[i] = words[i].ToUpper();
            //}
            int x = 0;
            foreach(string i in words)
            {
                words[x] = words[x].ToUpper();
                x++;
            }
        }
    }
}
