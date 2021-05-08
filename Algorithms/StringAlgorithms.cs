using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class StringAlgorithms
    {
        public static string RemoveDuplicateChars(string input)
        {
            StringBuilder storeEncounteredLettes = new StringBuilder();

            foreach (char chr in input)
            {
                if(storeEncounteredLettes.ToString().IndexOf(chr) == -1)
                {
                    storeEncounteredLettes.Append(chr);
                }
            }
            
            return storeEncounteredLettes.ToString();
        }

        public static bool IsAnagrams(string input1, string input2)
        {

            char[] chr1 = input1.ToLower().ToCharArray();
            char[] chr2 = input2.ToLower().ToCharArray();

            Array.Sort(chr1);
            Array.Sort(chr2);

            string sortedInput1 = new string(chr1);
            string sortedInput2 = new string(chr2);

            return sortedInput1.Trim() == sortedInput2.Trim();
        }

        public static bool IsPalidrome(string input)
        {
            int min = 0;
            int max = input.Length - 1;

            while (true)
            {
                if (min > max)
                    return true;

                char frontChar = input[min];
                char behindChar = input[max];

                if (char.ToLower(frontChar) != char.ToLower(behindChar))
                    return false;

                min++;
                max--;
            }
        }

        public static bool IsUnique(string input)
        {
            StringBuilder storeEncounteredLettes = new StringBuilder();

            foreach (char chr in input)
            {
                if (storeEncounteredLettes.ToString().IndexOf(chr) == -1)
                {
                    storeEncounteredLettes.Append(chr);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static string Reverse(string input)
        {
            StringBuilder response = new StringBuilder();
            for (int i = input.Length -1 ; i  >= 0; i--)
            {
                response.Append(input.ToString()[i]);
            }

            return response.ToString();
        }

        public static int WordCount(string input)
        {
            int response = 0;

            //Remove whitespaces from begginning and end of the string
            input = input.Trim(); 

            //Necassary because foreach will execute once with empty string returning 1
            if (input == "")
                return response;

            //Ensure there is only one space between each word
            while (input.Contains("  "))
                input = input.Replace("  ", " ");

            return input.Split(' ').Length;
        }

        
    }
}
