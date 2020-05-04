using System;
using Xunit;
using Assert = Xunit.Assert;
namespace StudyCoreTest
{
    public class Tests
    {
        [Fact]
        public void TestAdd()
        {


        }
        [Fact]
        public void TestMax()
        {
            Assert.Equal(3, Math.Max(3, 2));
        }

    }
}
