using BusinessLayer;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace TestProject
{
    public static class UnitTest4
    {
        [Fact]
        public static void TestDoubles()
        {
            List<Person> persons = new Person().GetPersons();

            // Execute tests until the end :
            using(new AssertionScope())
            {
                persons.Should().NotBeNullOrEmpty();
                persons.Should().HaveCount(4);
                persons.Should().OnlyHaveUniqueItems();
                persons.Should().ContainEquivalentOf(new Person() {Age = 12, Name = "alex"});
            }
        }
    }
}
