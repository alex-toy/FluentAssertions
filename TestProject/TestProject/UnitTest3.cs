using FluentAssertions;
using System.Reflection;
using Xunit;

namespace TestProject
{
    public static class UnitTest3
    {
        [Fact]
        public static void TestAssembly()
        {
            Assembly? core = Assembly.Load(nameof(Core));
            Assembly? business = Assembly.Load(nameof(BusinessLayer));
            Assembly? data = Assembly.Load(nameof(DataLayer));

            business.Should().Reference(core);
            business.Should().NotReference(data);
            data.Should().Reference(core);
        }
    }
}
