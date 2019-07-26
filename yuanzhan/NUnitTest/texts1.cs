using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class texts1
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            int[] array = { 1, 5, 1, 8, 9, 44 };
        }

        [Test]
        public void Test2()
        {
            int[] array = { 1, 5, 1, 8, 9, 44 };
            Assert.That(array.Length,Is.EqualTo(6));
            Assert.That(array,Is.Not.Null);
        }
    }
}
