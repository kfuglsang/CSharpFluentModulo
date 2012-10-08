﻿using NUnit.Framework;
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
        public void NullSourceThrowsArgumentException()
        {
            IEnumerable<int> source = null;
            Assert.Throws<ArgumentNullException>(() => source.Every(3));
        }

        [Test]
        public void EveryThirdItemIsOutput()
        {
            var inputList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };


        }
    }
}