using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class ArrayAlgorithms
    {
        public static int[] RotateArrayRight(int[] input, int pivot)
        {
            //int[] response = new int[input.Length];

            //int index = 0;

            //for (int i = pivot; i < input.Length; i++)
            //{
            //    response[index] = input[i];
            //    index++;
            //}

            //for (int i = 0; i < pivot; i++)
            //{
            //    response[index] = input[i];
            //    index++;
            //}

            //return response;

            return input.Skip(pivot).Concat(input.Take(pivot)).ToArray();
            
        }

        public static bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            foreach (var item in arr)
            {
                bool isExist = arr.Contains((target - item));

                if (isExist)
                    return true;
            }

            return false;
        }

        public static int GetMajorityElement(params int[] inputs)
        {
            Dictionary<int, int> storeElement = new Dictionary<int, int>();

            foreach (int input in inputs)
            {
                if (!storeElement.ContainsKey(input))
                {
                    storeElement.Add(input, 1);
                }
                else
                {
                    int value = storeElement.GetValueOrDefault(input);
                    storeElement[input] =  value + 1;
                }
            }

            int max = 0;
            int key = -1;
            foreach (KeyValuePair<int,int> keyValuePair in storeElement)
            {
                if(keyValuePair.Value > max)
                {
                    max = keyValuePair.Value;
                    key = keyValuePair.Key;
                }               
            }
            
            return key;
        }

        public static int[] MinMaxArraySwap(int[] input)
        {
            int max = 0;
            int min = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > input[max])
                    max = i;

                if (input[i] < input[min])
                    min = i;
            }

            int tempMin = input[min];
            input[min] = input[max];
            input[max] = tempMin;

            return input;
        }        
       
    }
}
