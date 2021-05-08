using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgorithmsUnitTests
{
    public class ArrayAlgorithmsUnitTests
    {
        [Fact]
        public void RotateArrayRight_Test()
        {
            int[] input = new int[] { 1, 5, 3, 6, 7, 8, 9, 11, 12 };

            int[] value1 = ArrayAlgorithms.RotateArrayRight(input, pivot: 4);

            int[] expectedOutput = new int[] { 7, 8, 9, 11, 12, 1, 5, 3, 6 };

            bool isEqual = Enumerable.SequenceEqual(expectedOutput, value1);

            Assert.True(isEqual);
        }

        [Fact]
        public void TwoIntegersSumToTarget_Test()
        {
            int[] input = new int[] { 1, 15, 99, 84 };

            //84 + 15 = 99 => return true
            bool value1 = ArrayAlgorithms.TwoIntegersSumToTarget(input, target: 99);
            
            Assert.True(value1);
        }

        [Fact]
        public void GetMajorityElement_Test()
        {
            int[] input = new int[] { 1, 15, 99, 84, 5, 15 };
            //array içerisinde en çok bulunan değer 15 oluduğu için 15 dönmeli,  bu tür turumlarda dictinary kullanabiliriz
            int value1 = ArrayAlgorithms.GetMajorityElement(input);

            Assert.True(value1 == 15);
        }

        [Fact]
        public void MinMaxArraySwap_Test()
        {
            int[] input = new int[] { 1, 15, 99, 84, 5, 15 };

            //en küçün değer olan 1 ile en büyük değer olan 99'un yerlerini değiştiriyoruz
            int[] value1 = ArrayAlgorithms.MinMaxArraySwap(input);

            int[] expectedOutput = new int[] { 99, 15, 1, 84, 5, 15 };

            bool isEqual = Enumerable.SequenceEqual(expectedOutput, value1);

            Assert.True(isEqual);
        }
    }
}
