using FluentAssertions;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = "value";

            x.Should().Be("value");
        }
    }
}