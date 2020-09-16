using System;
using Xunit;

namespace booking_project.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var func = new Program();
            Assert.Equal(func.Main("Maxim"), "Hello Maxim!"); // True test
            Assert.Equal(func.Main("Valya"), "Hello Maxim!"); // False test
        }
    }
}
