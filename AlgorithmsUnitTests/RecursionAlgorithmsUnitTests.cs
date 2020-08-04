using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgorithmsUnitTests
{
    public class RecursionAlgorithmsUnitTests
    {
        [Fact]
        public void MinMaxArraySwap_Test()
        {
            int input = 15896;

            int value1 = RecursionAlgorithms.SumDigits(input);

            Assert.True(value1 == 29);
        }

        [Fact]
        public void ConvertDecimalToBinary_Test()
        {
            int input = 325;

            List<string> result = new List<string>();

            int value1 = RecursionAlgorithms.ConvertDecimalToBinary(input, result);

            string binary = string.Join("", result);

            Assert.True(binary == "101000101");
        }

        [Fact]
        public void Power_Test()
        {
            int input = 3;
            
            int value1 = RecursionAlgorithms.Power(input, input);           

            Assert.True(value1 == 27);
        }

        [Fact]
        public void FibonacciSeries_Test()
        {
            int input = 25;

            int value1 = RecursionAlgorithms.FibonacciSeries(input);

            Assert.True(value1 == 75025);
        }

        [Fact]
        public void BinarySearchRecursive_Test()
        {
            int[] input = new int[] { 10,45,232, 4, 565, 22, 234, 34};

            Array.Sort(input);

            int value1 = RecursionAlgorithms.BinarySearchRecursive(input, 22, 0, input.Length);

            Assert.True(value1 == 3);
        }

        [Fact]
        public void QuickSortRecursive_Test()
        {
            int[] input = new int[] { 10, 45, 232, 4, 565, 22, 234, 34 };

            RecursionAlgorithms.QuickSortRecursive(input, 0, input.Length -1);

            int[] expectedOutput = new int[] { 4, 10, 22, 34, 45, 232, 234, 565 };

            bool isEqual = Enumerable.SequenceEqual(expectedOutput, input);

            Assert.True(isEqual);
        }

        [Fact]
        public void GCDRecursive_Test()
        {  

            int result = RecursionAlgorithms.GCDRecursive(10, 135);
            
            Assert.True(result == 5);
        }

        [Fact]
        public void LCMRecursive_Test()
        {

            int result = RecursionAlgorithms.LCMRecursive(10, 135);

            Assert.True(result == 270);
        }

        [Fact]
        public void LinkedListRecursiveAlgorithms_Test()
        {
            Node head = null;

            LinkedListRecursiveAlgorithms.Append(ref head, 25);
            LinkedListRecursiveAlgorithms.Append(ref head, 5);
            LinkedListRecursiveAlgorithms.Append(ref head, 18);
            LinkedListRecursiveAlgorithms.Append(ref head, 7);

            string result = LinkedListRecursiveAlgorithms.Print(head);

            LinkedListRecursiveAlgorithms.Reverse(ref head);

            result = LinkedListRecursiveAlgorithms.Print(head);

            LinkedListRecursiveAlgorithms.ReverseUsingRecursion(head);

            head = LinkedListRecursiveAlgorithms.newHead;

            result = LinkedListRecursiveAlgorithms.Print(head);

            Assert.True(true);
        }
    }
}
