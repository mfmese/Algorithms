using Algorithms;
using System;
using Xunit;

namespace AlgorithmsUnitTests
{
    public class StringAlgorithmsUnitTests
    {
        [Fact]
        public void RemoveDuplicateChars_Test()
        {
            string value1 = StringAlgorithms.RemoveDuplicateChars("Google");
            string value2 = StringAlgorithms.RemoveDuplicateChars("Yahoo");
            string value3 = StringAlgorithms.RemoveDuplicateChars("Line1\\Line2\\Line3");
  

            Assert.True(value1 == "Gogle" && value2 == "Yaho");
        }

        [Fact]
        public void IsAnagrams_Test()
        {
            bool value1 = StringAlgorithms.IsAnagrams("Paris", "Pairs");
            bool value2 = StringAlgorithms.IsAnagrams("Las Vegas", "Salvages");
            bool value3 = StringAlgorithms.IsAnagrams("Dormitory", "Dirty room");
            bool value4 = StringAlgorithms.IsAnagrams("Night", "Think");

            Assert.True(value1 && value2 && value3 && !value4);
        }

        [Fact]
        public void IsPalidrome_Test()
        {
            bool value1 = StringAlgorithms.IsPalidrome("Radar");
            bool value2 = StringAlgorithms.IsPalidrome("Kayak");
            bool value3 = StringAlgorithms.IsPalidrome("racecar");
            bool value4 = StringAlgorithms.IsPalidrome("levelup");

            Assert.True(value1 && value2 && value3 && !value4);
        }

        [Fact]
        public void IsUnique_Test()
        {
            bool value1 = StringAlgorithms.IsUnique("abcdef");
            bool value2 = StringAlgorithms.IsUnique("abcad");
            bool value3 = StringAlgorithms.IsUnique("123try");

            Assert.True(value1 && !value2 && value3);
        }

        [Fact]
        public void Reverse_Test()
        {
            string value1 = StringAlgorithms.Reverse("Paris");
            string value2 = StringAlgorithms.Reverse("Las Vegas");
            string value3 = StringAlgorithms.Reverse("Dormitory");

            Assert.True(value1 == "siraP");
        }

        [Fact]
        public void WordCountTest()
        {
            int value1 = StringAlgorithms.WordCount(" Paris is a  very great  city ");

            Assert.True(value1 == 6);
        }

        
    }
}
