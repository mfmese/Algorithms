using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class RecursionAlgorithms
    {
        public static int SumDigits(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return (number % 10 + SumDigits(number / 10));
            }
        }

        public static int ConvertDecimalToBinary(int number, List<string> result)
        {
            int binary;
            if(number == 0)
            {
                return 0;
            }
            else
            {
                binary = (number % 2) + ConvertDecimalToBinary(number / 2, result);
                result.Add(binary.ToString());
                return 0;
            }
        }

        public static int Power(int @base, int exponent)
        {
            if(exponent < 0)
            {
                throw new Exception("Only positive exponent can be allowed");
            }
            else if(exponent == 1)
            {
                return @base;
            }
            else if(exponent == 0)
            {
                return 1;
            }
            else
            {
                return @base * Power(@base, exponent - 1);
            }
            
        }

        //Formul: F(n) = F(n-1) + F(n-2)
        //F(n-1) is the previous term (n-1).
        //F(n-2) is the term before that(n-2).
        //Exmple: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34… 
        public static int FibonacciSeries(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            return FibonacciSeries(number - 1) + FibonacciSeries(number - 2);
        }

        public static int BinarySearchRecursive(int[] input, int key, int min, int max)
        {
            if(min > max)
            {
                throw new Exception("Min could not be bigger than Max!");
            }
            else
            {
                int mid = (min + max) / 2;

                if(key == input[mid])
                {
                    return ++mid;
                }
                else if( key < input[mid])
                {
                    return BinarySearchRecursive(input, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(input, key, mid + 1, max);
                }
            }
        }

        public static int BinarySearchIterative(int[] input, int key, int min, int max)
        {
            while(min <= max)
            {
                int mid = (min + max) / 2;

                if(key == input[mid])
                {
                    return ++mid;
                }
                else if(key < input[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            throw new Exception("Min could not be bigger than Max!");
        }

        public static void QuickSortRecursive(int[] input, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(input, left, right);

                if (pivot > 1)
                    QuickSortRecursive(input, left, right - 1);

                if (pivot + 1 < right)
                    QuickSortRecursive(input, pivot + 1, right);
            }            
        }

        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[left];

            while (true)
            {
                while (input[left] < pivot)
                    left++;

                while (input[right] > pivot)
                    right--;

                if(left < right)
                {
                    int temp = input[right];
                    input[right] = input[left];
                    input[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        //En büyük ortak bölen (Greatest Common Divisor)
        public static int GCDRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCDRecursive(a % b, b);
            else
                return GCDRecursive(a, b % a);
        }

        //En küçük ortak kat (Least common multiple)
        public static int LCMRecursive(int a, int b)
        {
            return a * b / GCDRecursive(a, b);
        }
    }
}
