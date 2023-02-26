using BusinessLayer;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public static class UnitTest5
    {
        [Fact]
        public static void TestDoubles()
        {
            Item? item = new Item() { Name = "iphone", Value = 128 };
            Item? itemDto = new Item() { Name = "iphone", Value = 128 };

            item.Should().BeEquivalentTo(itemDto);
            item.Should().BeEquivalentTo(itemDto, option => option.Excluding(item => item.Name));
            item.Should().BeEquivalentTo(itemDto, option => option.ExcludingMissingMembers());
            item.Should().BeEquivalentTo(itemDto, option => option.WithAutoConversionFor(item => item.Path.Contains("Value")));
        }
    }
}
