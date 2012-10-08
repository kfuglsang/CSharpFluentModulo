using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentModulo.Tests
{
    [TestFixture]
    public class EnumerableExtensionMethodTests
    {
        [Test]
        public void EmptyInputYieldsNoResults()
        {
            var inputList = new List<int>()
            {
            };

            var expected = new List<int> { };
            var actual = inputList.Every(1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void EveryItemIsOutput()
        {
            var inputList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = inputList.Every(1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void EverySecondItemIsOutput()
        {
            var inputList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var expected = new List<int> { 2, 4, 6, 8, 10 };
            var actual = inputList.Every(2);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void EveryThirdItemIsOutput()
        {
            var inputList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var expected = new List<int> { 3, 6, 9 };
            var actual = inputList.Every(3);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
