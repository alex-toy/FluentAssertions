using FluentAssertions;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestStrings()
        {
            string actualString = "value";
            actualString.Should().Be("value");
            actualString.Should().NotBeEmpty();
            actualString.Should().HaveLength(5);
            actualString.Should().Contain("al");
            actualString.Should().Contain("al", Exactly.Once());
            actualString.Should().Contain("al", MoreThan.Twice());
            actualString.Should().Contain("al", LessThan.Thrice());
            //actualString.Should().Contain("al", MoreThan.Equals(6));
            actualString.Should().ContainEquivalentOf("AL");

            string actualString2 = "Value";
            actualString2.Should().BeEquivalentTo("value");

            string nullString = null;
            nullString.Should().BeNull("Because I want that to be so.");
            nullString.Should().NotBeNull();
            nullString.Should().BeNullOrWhiteSpace();
            nullString.Should().NotBeNullOrWhiteSpace();

            string emptyString = "";
            emptyString.Should().BeEmpty();
        }

        [Fact]
        public void TestInts()
        {
            int number = 5;

            number.Should().Be(6);
            number.Should().BePositive();
            number.Should().BeNegative();

            number.Should().BeGreaterThan(6);
            number.Should().BeGreaterThanOrEqualTo(6);
            number.Should().BeLessThan(6);
            number.Should().BeLessThanOrEqualTo(6);

            number.Should().BeInRange(6, 19);
            number.Should().NotBeInRange(6, 19);
        }

        [Fact]
        public void TestDoubles()
        {
            double number = 5.9999999999;

            number.Should().BeApproximately(6, 0.000001);
            number.Should().NotBeApproximately(6, 0.000001);
        }
    }
}